using DlibDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AForgeCamera
{
    /// <summary>
    /// class represents the landmark of the face shape prediction
    /// </summary>
    public class Landmarks
    {
        /// <summary>
        /// first index of the landmark
        /// </summary>
        public int FirstIndex { get; }
        /// <summary>
        /// last index of the landmark
        /// </summary>
        public int LastIndex { get; }
        /// <summary>
        /// list of the landmark points
        /// </summary>
        private List<Point> _landMarkPointList { get; set; }
        /// <summary>
        /// object of the predicted face shape
        /// </summary>
        private FullObjectDetection _shape { get; }
        /// <summary>
        /// list of the landmark points
        /// </summary>
        public List<Point> LandMarkPointList
        {
            get
            {
                if (_landMarkPointList == null)
                {
                    _landMarkPointList = GetLandmarkList(this.FirstIndex,this.LastIndex,this._shape);
                }
                return _landMarkPointList;
            }
        }

        public Landmarks(int firstIdx, int lastidx, FullObjectDetection shape)
        {
            this.FirstIndex = firstIdx;
            this.LastIndex = lastidx;
            this._shape = shape;
        }
        /// <summary>
        /// Get the list of the landmarks based on the given first and last index and the face shape object
        /// </summary>
        /// <param name="firstIdx">first index of the landmark (0-67)</param>
        /// <param name="lastIdx">last index of the landmark (0-67)</param>
        /// <param name="shape">object of the predicted face shape</param>
        /// <returns>List of the landmarks</returns>
        private List<Point> GetLandmarkList(int firstIdx, int lastIdx, FullObjectDetection shape)
        {
            try
            {
                if (shape != null)
                {
                    List<Point> res = new List<Point>();
                    for (uint i = Convert.ToUInt32(firstIdx); i <= Convert.ToUInt32(lastIdx); i++)
                    {
                        res.Add(shape.GetPart(i));
                    }
                    return res;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Failed to Get Landmark List from index {0} to index {1}. Exception: {2}",firstIdx,lastIdx,ex.Message));
            }
        }
        /// <summary>
        /// Get the rectangle border of the landmarks
        /// </summary>
        /// <returns>ractangle border of the landmarks</returns>
        public Rectangle GetLandmarkRectangle()
        {
            if (this.LandMarkPointList != null)
            {
                int margin = 5;
                int left = -1;
                int right = -1;
                int top = -1;
                int bottom = -1;
                foreach (var p in this.LandMarkPointList)
                {
                    left = left == -1 ? p.X : Math.Min(left, p.X);
                    right = right == -1 ? p.X : Math.Max(right, p.X);
                    top = top == -1 ? p.Y : Math.Min(top, p.Y);
                    bottom = bottom == -1 ? p.Y : Math.Max(bottom, p.Y);
                }

                return  new Rectangle(
                                       new Point(left-margin, top- margin),
                                       new Point(right+ margin, bottom+ margin));
            }
            return new Rectangle(new Point(0, 0),
                                 new Point(0, 0));
        }
    }
}
