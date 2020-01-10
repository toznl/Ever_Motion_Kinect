using System;
using System.IO;

namespace Ever_Motion_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string border_line = "-1	30	5	6	7	8	11	12	13	14";
            int arm01 = 0, arm02 = 0, arm03 = 0, arm04 = 0;
            int _arm01 = 0, _arm02 = 0, _arm03 = 0, _arm04 = 0;
            
            StreamWriter outputFile;

            int angle_gap = 45;
            int angle_gap2 = 40;
            int scene_num = 0;
            int scene_num2 = scene_num + 5000;

            int time_1 = 0;
            int time_2 = 1;
            int time_3 = 2;
            int time_4 = 3;
            int time_5 = 4;
            int time_6 = 5;

    

            for (int i = 0; i < 100; i += angle_gap) //arm01
            {
                _arm01 = i / angle_gap;
                arm01 = i;
                Console.WriteLine(i);

                for (int j = 0; j < 100; j += angle_gap) //arm02
                {
                    _arm02 = j / angle_gap;
                    arm02 = j;
                    for (int k = -45; k < 50; k += angle_gap) //arm03
                    {
                        _arm03 = (k + 45) / angle_gap;
                        arm03 = k;
                        for (int l = 0; l < 100; l += angle_gap) //arm04
                        {
                            _arm04 = l / angle_gap;
                            arm04 = l;

                            string contents = "0" + "	" + arm01 + "	" + arm02 + "	" + arm03 + "	" + arm04 + "	" + arm01 + "	" + arm02 + "	" + arm03 + "	" + arm04;
                            string file_name = "Tele" + _arm01 + _arm02 + _arm03 + _arm04;
                            Console.WriteLine(arm01);


                            outputFile = new StreamWriter(@"..\..\..\..\..\" + file_name + ".txt", true);
                            //outputFile = new StreamWriter(@"..\..\..\..\..\total.txt", true);

                            outputFile.WriteLine(border_line);

                            outputFile.WriteLine(time_1 + "	" + contents);
                            outputFile.WriteLine(time_2 + "	" + contents);
                            outputFile.WriteLine(time_3 + "	" + contents);
                            outputFile.WriteLine(time_4 + "	" + contents);
                            outputFile.WriteLine(time_5 + "	" + contents);
                            outputFile.WriteLine(time_6 + "	" + contents);


                            //time_1 += 6;
                            //time_2 += 6;
                            //time_3 += 6;
                            //time_4 += 6;
                            //time_5 += 6;
                            //time_6 += 6;


                            //outputFile = new StreamWriter(@"..\..\..\..\..\" + "scene.txt", true);
                            //outputFile.WriteLine(scene_num + "," + scene_num2 + ",1,Gesture:" + file_name);
                            //scene_num += 5100;
                            //scene_num2 += 5100;

                            outputFile.Close();

                        }
                    }
                }



            }
        }
    }
}
