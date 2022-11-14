using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment
{
    class Yeucau
    {
        private string _connection;
        public Yeucau(string connection)
        {
            _connection = connection;
        }
        ~Yeucau()
        {
	        _connection = null;
	    }
	
        /// <summary>
	    /// Nhập mới lớp học
        /// </summary>
	    public void Yeucau01()
	    {
            Console.Clear();

            bool flagTieptuc = false;
            string kytu = "";
            string nameClass;
	
	        var lophoc = new Lophoc(_connection);            

            do
	        {
                flagTieptuc = false;
	
	            Console.Write("\n\tTên lớp: ");
	            nameClass = Console.ReadLine();

	            if (nameClass != "")
	            {
                    lophoc.InsertLophoc(nameClass);
	            }
                Console.Write("\n\tNhập Y để tiếp tục (ký tự khác để thoát): ");

                kytu = Console.ReadLine();
                if (kytu == "Y" || kytu == "y")
                {
                    flagTieptuc = true;
                }
                else
                {
                    Console.Write("\n\tThoát chức năng.");
                }

            } while (flagTieptuc) ;
        }

        /// <summary>
        /// Sửa lớp học
        /// </summary>
        public void Yeucau02()
        {
        Console.Clear();

        bool flagTieptuc = false;
                    string kytu = "";
                     string nameClass;
                    int idClass;
        var lophoc = new Lophoc(_connection);
                     do
                         {
            flagTieptuc = false;
       
            Console.Write("\n\tMã lớp: ");
            idClass = int.Parse(Console.ReadLine());
            Console.Write("\n\tTên lớp: ");
            nameClass = Console.ReadLine();
                             if (nameClass != "")
                                 {
               lophoc.UpdateLophoc(idClass, nameClass);
                                }
        
            Console.Write("\n\tNhập Y để tiếp tục (ký tự khác để thoát): ");
            kytu = Console.ReadLine();
                             if (kytu == "Y" || kytu == "y")
                                 {
                flagTieptuc = true;
                                 }
                             else
                                 {
                Console.Write("\n\tThoát chức năng.");
                               }
                         } while (flagTieptuc) ;
        }
             /// <summary>
             /// In danh sách lớp học
             /// </summary>
             public void Yeucau03()
             {
     Console.Clear();
     var lophoc = new Lophoc(_connection);
    var list = lophoc.GetListLophoc();

                    Console.Write("\n\tDanh sách lớp.");
                    Console.WriteLine("\n\tMã số: " + "\t Tên lớp: ");
                    foreach (var item in list)
                    {
                        Console.Write("\n\t" + item.IdClass + "\t" + item.NameClass);
             }
                Console.WriteLine();
                Console.ReadLine();
             }
    }

}

