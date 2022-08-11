//bhaavan bhullar
//december 6 2021
// removing list assignment
// this program is designed in order to add, remove and view the employees in a company called Game development inc, it has all of the functions that will add the employees to the company, remove them from the company based on there employee number
//it also displays all of the employees that are in the company when you ask it to do so. it uses a list and a sublist in order to store the string values the individual has entered.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Employee_records
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> myList = new List<List<string>>();// this declares a string list called myList, which will store all of the employees within the comapny, it also known as the master list
            List<String> subList = new List<string>();// this decalres another string list called sublist, this will store the values of the employees inputted by the user

            Boolean loop = true;// this creates a boolean variable called loop, and it is set to true, this value will be used in order to run the loop for selecting what you want

            Console.WriteLine("Employee list for Game Development Inc");//print statement

            while (loop)// this is a while loop that states that it will run as long the the loop variable is set to true, if it is set to false 
            {
                
                Console.WriteLine();//creates space
                Console.WriteLine("Enter 1 to add an employee");//WriteLine 
                Console.WriteLine("Enter 2 to remove an employee");//WriteLine
                Console.WriteLine("Enter 3 to print out the employees currently at this company");//writelines 
                Console.WriteLine("Enter 4 to exit the list program");// writeline
                Console.WriteLine();// add space
                Console.Write("Your choice: ");//writeline
                int choice = int.Parse(Console.ReadLine());//this converts the string varibale that was entered by the user into a int varible using the int.parse function and stores it in the variable called choice

                if (choice == 1)// this says that if the user inputted number is equal to 1 then it will run through this loop 
                {
                    Console.WriteLine();//space
                    Console.Write("Please enter the employee number: ");
                    string employee_num = Console.ReadLine();// reads in the users inut for the employee number and stores it in a string varible called employee_num, this is the most important variable

                    Console.Write("Please enter the employee's frist name: ");
                    string employee_name = Console.ReadLine();//reads in the user input for the employees first name and stores it in a string varible called employee_name

                    Console.Write("please enter the employee's last name: ");
                    string employee_last_name = Console.ReadLine();// reads in the user input for the employees last name and stores it in a string varible called employee_last_name

                    Console.Write("Please enter the employee's salary: ");
                    string employee_salary = Console.ReadLine();// reads in the user input for the employees salary and stores it in a string variable called employee_salary

                    Console.Write("Please enter the employee's start date with the company: ");
                    string employee_start_date = Console.ReadLine();// reads in the user input for the employee start date and stores it in a string variable called employee_start_date
                    Console.WriteLine();
                    Console.WriteLine("Your employee has been added");
                    
                    myList.Add(new List<string> { employee_num, employee_name, employee_last_name, employee_salary, employee_start_date });// this function adds all of the inputted strings by the user into a single list it does this by taking in all of the string varibles we declared and acesses its storage the main point of this is to add an employee to the company , it stores it seperate in a sublist everytime and individual adds someone to the company, 

                }

                else if (choice == 2)// this states that if the users choice were to equal to the int value of 2 then it would run through this loop
                {
                    Console.WriteLine("What is the employee number");
                    string employee_num = Console.ReadLine();// this reads in the users input for the employee number and sotres it back in the varible called employee_num which was used to add someone to the list but this time it will be used to remove the employee using his employee number

                    for (int i = 0; i < myList.Count; i++)// this is a for loop that starts at the value of 0 and keeps repeating until until the value reaches the amount of elements in the list and then increments and puts it through the loop 
                    {
                        if (employee_num == myList[i][0])// this states that if the the employee number which is stored in the varible called employee_num is equal to a value in the list at position 0  where the employee num is orginally sotred then it will run through this statement
                        {
                            myList.RemoveAt(i);// this function removes the employee from the list by using the remove at function, it looks at the i varibale which contains the employee number and removes it

                            
                        }

                        else if (employee_num != myList[i][0])// this else if statement says that if the employee number is not foound within the list at position 0 thn it will run through this statement
                        {
                            Console.WriteLine("This employee does not exist");// print statement
                        }
                    }
                }

                else if (choice == 3)// this else if statement states that if the users input called choice euquals 4 then it will go through this statement
                {
                        for (int i = 0; i < myList.Count; i++)//this is a for loop that starts at the value of 0 and keeps repeating until until the value reaches the amount of elements in the list and then increments and puts it through the loop 
                    {

                            for (int j = 0; j < 5; j++)// this is another for loop which is known as a nested for loop, this starts at the value of 0 and continues to increment up till the value of 5 because that is how many items are asked by the program to the user, the difference between this loop and the last one is that this one particularly looks at a individual in the list and all of its details while the last loop looks at everything within the list and puts it through to this line of code
                            {

                            
                                Console.Write(myList[i][j] + " ");// this line of code is a print statement that will print out all of the employees that have been added to the list and will add spaces between each detail

                            }
                            /*
                            if (!myList.Any()) // this part i am a little confused about, i was trying to add a function that says if there is nothing in the list then it will print out the following statement
                            {
                            Console.WriteLine("There are no employees at this comapny");
                            }
                            */

                        Console.WriteLine();//adds space

                            
                        }

                }
                else if ( choice== 4)// this else if statement says the if the user input which is stored in the variable called choice is equal to 4 then it will go through this statement
                {
                    Console.WriteLine("Thank you for using the list program");
                    loop=false; break;// this sets the orignal boolean variable called loop that was true to false and then breaks it out of the loop, the reason this works is because the loop only runs if it is true
                }

                else// this is an else statement that says if the user has entered any of the other numbers than the ones that were identified above then it will run through this code
                {
                    Console.WriteLine("You have entered the wrong number please enter again");
                }
                Console.WriteLine();

            }

        }
    }
}
