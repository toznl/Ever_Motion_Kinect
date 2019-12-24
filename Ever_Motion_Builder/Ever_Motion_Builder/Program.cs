using System;
using System.IO;

namespace Ever_Motion_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string border_line = "1	2	3	4	5	6	7	8	9	10";

            int arm01 = 0, arm02 = 0, arm03 = 0, arm04 = 0, arm05 = 0;
            int _arm01 = 0, _arm02 = 0, _arm03 = 0, _arm04 = 0, _arm05 = 0;
            StreamWriter outputFile;

            int angle_gap = 30;

            for (int i = 0; i < 100; i += angle_gap) //arm01
            {
                _arm01 = i / angle_gap;
                arm01 = i;

                for (int j = 0; i < 100; j += angle_gap) //arm02
                {
                    _arm02 = j / angle_gap;
                    arm02 = j;
                    for (int k = 0; k < 100; k += angle_gap) //arm03
                    {
                        _arm03 = k / angle_gap;
                        arm03 = k;
                        for (int l = 0; l < 100; l += angle_gap) //arm04
                        {
                            _arm04 = l / angle_gap;
                            arm04 = l;
                            for (int m = 0; m < 100; m += angle_gap) //arm05
                            {
                                _arm05 = m / angle_gap;
                                arm05 = m;

                                string contents = arm01 + "	" + arm02 + "	" + arm03 + "	" + arm04 + "	" + arm05 + "	" + arm01 + "	" + arm02 + "	" + arm03 + "	" + arm04 + "	" + arm05;
                                string file_name = "Tele" + _arm01 + _arm02 + _arm03 + _arm04 + _arm05;
                                Console.WriteLine(file_name);
                                outputFile = new StreamWriter(@"..\..\..\..\..\" + file_name + ".txt");
                                outputFile.WriteLine(border_line);
                                outputFile.WriteLine(contents);
                                outputFile.Close();
                            }
                        }
                    }
                }



            }
        }
    }
}
