using customermanagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    class CustomerManagement
    {
        static void Main(string[] args)
        {

            CustomerManagement obj_Company = new CustomerManagement();
            List<Class1> CustomerList = new List<Class1>();
            char ans;
            int search_Id;
            do
            {
                Console.Clear();
                Console.WriteLine("***************************************************************************************");
                Console.WriteLine("**************************CUSTOMER MANAGEMENT SYSTEM MENU******************************");
                Console.WriteLine("***************************************************************************************");
                Console.WriteLine("* 1. Add Customer                                                                     *");
                Console.WriteLine("* 2. View Customer details                                                            *");
                Console.WriteLine("* 3. Search Customer details                                                          *");
                Console.WriteLine("* 4. Modify Customer details                                                          *");
                Console.WriteLine("* 5. Remove Customer details                                                          *");
                Console.WriteLine("* 6. Exit                                                                             *");
                Console.WriteLine("***************************************************************************************");
                Console.Write("Enter Your Choise Here:-");
                int choose_number = Convert.ToInt32(Console.ReadLine());

                switch (choose_number)
                {
                    case 1:
                        obj_Company.Function_Add_Customer(CustomerList);
                        obj_Company.Function_Display_Customer(CustomerList);
                        break;
                    case 2:
                        obj_Company.Function_Display_Customer(CustomerList);
                        break;
                    case 3:
                        Console.WriteLine("Enter Customer Id Which You Want To Search:");
                        search_Id = Convert.ToInt32(Console.ReadLine());
                        Class1 obj_search = obj_Company.Function_Search(CustomerList, search_Id);
                        if (obj_search != null)
                        {
                            Console.WriteLine("Customer ID \t{0}", obj_search.cust_Id);
                            Console.WriteLine("Customer Name \t{0}", obj_search.cust_Name);
                            Console.WriteLine("Customer Address \t{0}", obj_search.cust_Address);
                            Console.WriteLine("Contact \t{0}\n", obj_search.cust_contact);
                        }
                        else
                        {
                            Console.WriteLine("Record Not Found...!!!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Customer Id Which You Want To Search:");
                        search_Id = Convert.ToInt32(Console.ReadLine());
                        Class1 obj_Modify = obj_Company.Function_Search(CustomerList, search_Id);
                        if (obj_Modify != null)
                        {
                            Console.WriteLine("Customer ID      :" + obj_Modify.cust_Id);
                            Console.WriteLine("Customer Name    :" + obj_Modify.cust_Name);
                            Console.WriteLine("Customer Address :" + obj_Modify.cust_Address);
                            Console.WriteLine("Contact      :" + obj_Modify.cust_contact);
                            obj_Company.Fucntion_Modify_Customer(CustomerList, obj_Modify);
                            obj_Company.Function_Display_Customer(CustomerList);
                        }
                        else
                        {
                            Console.WriteLine("Record Not Found...!!!");
                        }

                        break;
                    case 5:
                        Console.WriteLine("Enter Customer Id Which You Want To Search:");
                        search_Id = Convert.ToInt32(Console.ReadLine());
                        Class1 obj_Delete = obj_Company.Function_Search(CustomerList, search_Id);
                        if (obj_Delete != null)
                        {
                            Console.WriteLine("Customer ID      :" + obj_Delete.cust_Id);
                            Console.WriteLine("Customer Name    :" + obj_Delete.cust_Name);
                            Console.WriteLine("Customer Address :" + obj_Delete.cust_Address);
                            Console.WriteLine("Contact      :" + obj_Delete.cust_contact);
                            obj_Company.Function_Remove(CustomerList, obj_Delete);
                            obj_Company.Function_Display_Customer(CustomerList);
                        }
                        else
                        {
                            Console.WriteLine("Record Not Found...!!!");
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalide Choise....!!! Please Enter Correct Choice...!!!");
                        break;
                }
                Console.Write("Would You Like To Continue(Y/N):");
                ans = Convert.ToChar(Console.ReadLine());
            } while (ans == 'y' || ans == 'Y');
        }


        public void Function_Add_Customer(List<Class1> CustomerList)
        {
            Class1 obj_Comapny1 = new Class1();
            Console.Write("Enter Customer Id:");
            obj_Comapny1.cust_Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer Name:");
            obj_Comapny1.cust_Name = Console.ReadLine();
            Console.Write("Enter Customer Addess:");
            obj_Comapny1.cust_Address = Console.ReadLine();
            Console.Write("Enter Customer Contact:");
            obj_Comapny1.cust_contact = Convert.ToInt32(Console.ReadLine());
          

            CustomerList.Add(obj_Comapny1);
            Console.WriteLine("Customer Deatil Added Successfully...!!!!:");
        }

        public void Function_Display_Customer(List<Class1> CustomerList)
        {
            Console.WriteLine("****************************Customer Details****************************************");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Customer Id\tCustomer Name\tCustomer Addess\tCustomer Contact");
            Console.WriteLine("------------------------------------------------------------------------------------");
            foreach (Class1 i in CustomerList)
            {
                Console.WriteLine(i.cust_Id + "      \t|  " + i.cust_Name + " \t| " + i.cust_Address + "   \t|  " + i.cust_contact);
            }
            Console.WriteLine("------------------------------------------------------------------------------------");
        }

        public Class1 Function_Search(List<Class1> CustomerList, int search_Id)
        {
            return CustomerList.Find(emp => emp.cust_Id == search_Id);
        }


        public void Fucntion_Modify_Customer(List<Class1> CustomerList, Class1 obj_Modify)
        {
            Console.WriteLine("Chose Option for Modify Customer Detail:");
            Console.WriteLine("1.Id 2.Name 3.Address 4.Contact");
            int modify_number = Convert.ToInt32(Console.ReadLine());
            switch (modify_number)
            {
                case 1:
                    Console.WriteLine("Enter New Customer Id:");
                    int new_Id = Convert.ToInt32(Console.ReadLine());
                    obj_Modify.cust_Id = new_Id;
                    break;
                case 2:
                    Console.WriteLine("Enter New Customer Name:");
                    string new_Name = Console.ReadLine();
                    obj_Modify.cust_Name = new_Name;
                    break;
                case 3:
                    Console.WriteLine("Enter New Customer Address:");
                    string new_Address = Console.ReadLine();
                    obj_Modify.cust_Address = new_Address;
                    break;
                case 4:
                    Console.WriteLine("Enter New Customer Contact:");
                    int new_Contact = Convert.ToInt32(Console.ReadLine());
                    obj_Modify.cust_contact = new_Contact;
                    break;
                default:
                    Console.WriteLine("Invalide Choise....");
                    break;
            }
            // CustomerList.Add(obj_Modify);
        }

        public void Function_Remove(List<Class1> CustomerList, Class1 obj_Modify)
        {
            CustomerList.Remove(obj_Modify);
            Console.WriteLine("1 Record Removed SuccessFully....!!!");
        }


    }
}