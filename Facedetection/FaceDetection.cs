//NameSpace:    Facedetection
//FileName:     FaceDetection
//Create By:    raink
//Create Time:  2019/10/30 9:47:44

using System.Drawing;
using DlibDotNet;
using DlibDotNet.Extensions;

namespace AForgeCamera
{
    public class FaceDetection
    {
        private string faceDataPath;
        
        // 人脸数据文件路径名称属性
        public string FaceDataPath { get => faceDataPath; set => faceDataPath = value; }

        public FaceDetection()
        {
            //默认文件路径
            faceDataPath = @"face_data\shape_predictor_5_face_landmarks.dat";
        }

        /// <summary>
        /// 进行人脸识别
        /// </summary>
        /// <param name="image">图像</param>
        /// <param name="numOfFaceDetected"> 识别到的人脸数目</param>
        /// <returns></returns>
        public Bitmap FaceDetectionFromImage(Bitmap image, out int numOfFaceDetected)
        {
            numOfFaceDetected = 0;
            if (image != null)
            {
                // 图像转换到Dlib的图像类中
                Array2D<RgbPixel> img = BitmapExtensions.ToArray2D<RgbPixel>(image);


                using (var faceDetector = Dlib.GetFrontalFaceDetector())
                using (var shapePredictor = ShapePredictor.Deserialize(faceDataPath))
                {

                    // 检测人脸
                    var faces = faceDetector.Operator(img);

                    // 遍历检测到的人脸区域
                    foreach (var rect in faces)
                    {
                        //绘制脸部区域
                        Dlib.DrawRectangle(img, rect, new RgbPixel { Blue = 255 }, 3);
                        // 人脸区域中识别脸部特征
                        var shape = shapePredictor.Detect(img, rect);
                        // 简单绘制识别到的特征（用线连起来）
                        for (uint i = 1;i < shape.Parts; i++)
                        {
                            Dlib.DrawLine(img, shape.GetPart(i), shape.GetPart(i - 1), new RgbPixel { Red = 255 });
                        }
                    }
                    numOfFaceDetected = faces.Length;
                }
                return BitmapExtensions.ToBitmap<RgbPixel>(img);
            }
            return image;
        }
    }
}
