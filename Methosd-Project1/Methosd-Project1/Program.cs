using System;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace Methosd_Project1
{
    internal class Program
    {
        static string[] names = {};

        static void Main()
        {
           
            bool menu = false; 
            while (!menu)
            {
                Console.WriteLine( "\n"+ "1. siyahiya bax" + "\n" + "2. siyahiya ad elave et" + "\n" + "3. siyahida adi yolxa" + "\n" + "4. daxil edilmis indexdeki adi goster" + "\n" + "0. menudan cix" +"\n");
                Console.WriteLine("secim edin: ");
                int a = int.Parse(Console.ReadLine());
               
                switch (a)
                {
                    case 1:
                        ShowNames();
                        break;
                    case 2:
                        AddNames();
                        break;
                    case 3:
                        CheckName();
                        break;
                    case 4:
                        ShowIndexName();
                        break;
                    case 0:
                        menu = true;
                        break;
                    default:
                        Console.WriteLine("duzgun secim edin!!!");
                        break;



                }
            }
           
        }
        #region names



        public static void ShowNames()
        {
            Console.WriteLine("siyahidaki adlar :");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

        }


        #endregion


        #region add names

        public static void AddNames()
        {
            Console.WriteLine("elave etmek istediyiniz adi daxil edin :");
            string[] newArr = new string[names.Length + 1];
            string name = Console.ReadLine();
            bool result = true;          
            
             if (  name[0] >='0' && name[0]<='9'  )
             {
                 result = false;
                 Console.WriteLine("ad nomre ile baslaya bilmez");
                    
             }
            
            for (int i = 0; i < names.Length; i++) 
            {
                if (names[i] == name) 
                {
                    result = false;
                    Console.WriteLine(" ad siyahida var");
                    break;
                }
            }
            if (name.Length > 2 && result==true  )
            {

                        for (int j = 0; j < names.Length; j++)
                        {
                            newArr[j] = names[j];
                        }

                        newArr[newArr.Length - 1] = name;
                        names = newArr;
                        Console.WriteLine("ad ugurla elave olundu");
                                          
            }  
            else if (name.Length <=2 )           
            {
                Console.WriteLine("ad uygun deyil");
               
            }    
           
        }
        #endregion


        #region adi yoxla
        public static void CheckName()
        {
            Console.WriteLine("adi daxil edin :");
            string name = Console.ReadLine();
            for (int i = 0;i < names.Length;i++) 
            {
                if (names[i] == name)
                {
                    Console.WriteLine("ad siyahida var");
                    
                    return ;
                }               
            }
             Console.WriteLine("ad siyahida tapilmadi ");

        }
        #endregion

        #region
        public static void ShowIndexName() 
        {
            Console.WriteLine("index daxil edin :");
            int index = int.Parse(Console.ReadLine());
            if (index < names.Length && index>=0)
            {
                
                Console.WriteLine(names[index]); 
            }
            else
            {
                Console.WriteLine("bu indexde ad movcud deyil");
            }
        }
        #endregion



















    }
}
