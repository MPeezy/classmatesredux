/* Lab #4 Get to know you classmates
 Main difference between a list and an array? Arrays are a set size and you can't add or subtract slots. A list is flexible and you can add or subract slots.
*/


using System;

namespace StudentDatabase
{
    class Person
    {
        static void Main(string[] args)
        {
            //object
            Person person1 = new Person();
            person1.classList = "Andy Beer";
            person1.homeTown= "Berkley, MI";
            person1.favoriteFood = "French Fries";
            person1.isCool = "cool";

            Person person2 = new Person();
            person2.classList = "Cortez Christian";
            person2.homeTown = "Detroit, MI";
            person2.favoriteFood = "Chicken Fettuccine Alfredo";
            person2.isCool = "very cool";

            Person person3 = new Person();
            person3.classList = "Erin Walters";
            person3.homeTown = "Troy, MI";
            person3.favoriteFood = "Tacos";
            person3.isCool = "super cool";

            Person person4 = new Person();
            person4.classList = "Richard Moss";
            person4.homeTown = "Canton, MI";
            person4.favoriteFood = "Sushi";
            person4.isCool = "mad cool";

            Person person5 = new Person();
            person5.classList = "Huy Phan";
            person5.homeTown = "Lansing, MI";
            person5.favoriteFood = "Korean BBQ";
            person5.isCool = "extra cool";

            Person person6 = new Person();
            person6.classList = "Zachary Parr";
            person6.homeTown = "Wyandotte, MI";
            person6.favoriteFood = "Sushi";
            person6.isCool = "cool";

            Person person7 = new Person();
            person7.classList = "James Mitchell";
            person7.homeTown = "Yap, FSM";
            person7.favoriteFood = "Katsi";
            person7.isCool = "very cool";

            Person person8 = new Person();
            person8.classList = "Cullin Flynn";
            person8.homeTown = "Fowlerville, MI";
            person8.favoriteFood = "Pad Thai";
            person8.isCool = "super cool";

            Person person9 = new Person();
            person9.classList = "Cordero Ebberhart";
            person9.homeTown = "Berkley, MI";
            person9.favoriteFood = "BBQ";
            person9.isCool = "mad cool";

            Person person10 = new Person();
            person10.classList = "Rick Magdaleno";
            person10.homeTown = "Gilbert, AZ";
            person10.favoriteFood = "Hamburgers";
            person10.isCool = "cool";


            bool anotherStu = true;
            while (anotherStu == true)
            {

                string[] classList = { "Andy Beer", "Cortez Christian", "Erin Walters", "Richard Moss", "Huy Phan", "Zachary Parr", "James Mitchell", "Cullin Flynn", "Cordero Ebberhart", "Rick Magdaleno" };

                string[] homeTown = { "Berkley, MI", "Detroit, MI", "Troy, MI", "Canton, MI", "Lansing, MI", "Wyandotte, MI", "Yap, FSM", "Fowlerville, MI", "Berkley, MI", "Gilbert, AZ" };


                string[] favoriteFood = { "French Fries", "Chicken Fettuccine Alfredo", "Tacos", "Sushi", "Korean BBQ", "Sushi", "Katsu", "Pad Thai", "BBQ", "Hamburgers" };

                string[] isCool = { "cool", "very cool", "super cool", "mad cool", "extra cool", "cool", "very cool", "super cool", "mad cool", "cool" };



                Console.Write("Welcome to our C # class. Which student would you like to learn more about? (Enter a number 1-20): ");

                int numInClass = classList.Length;
                int studentNum = int.Parse(Console.ReadLine());




                  if (studentNum < 0 || studentNum > 9)

                    {
                        Console.WriteLine("That student doesn't exist. Please try again. Please enter a number between 0-9 ");
                    }
                    else
                    {
                        Console.WriteLine("Student " + studentNum + " is " + classList[studentNum] + ". What would you like to know about " + classList[studentNum] + "?(enter hometown or favorite food): ");

                    }


                    string answer = Console.ReadLine().ToLower();


                    if (answer == "hometown")

                    {
                        Console.WriteLine(classList[studentNum] + " is from  " + homeTown[studentNum] + " Would you like to know more? (enter y or n)");
                    }

                    else if (answer == "favorite food")

                    {
                        Console.WriteLine(classList[studentNum] + "'s favorite food is " + favoriteFood[studentNum] + " Would you like to know more? (enter y or n)");

                    }

                    else
                    {
                        Console.WriteLine("That data doesn't exist. Please try again. (enter hometown or favorite food: )");
                    }



                // know more?
                bool knowMore = true;
                while (knowMore == true)



                {

                        string moreAnswer = Console.ReadLine().ToLower();
                        if (moreAnswer == "y" && answer == "hometown")
                        {
                            Console.WriteLine(classList[studentNum] + "'s favorite food is " + favoriteFood[studentNum] + " and they are " + isCool[studentNum]);
                            Console.WriteLine("Would you like to learn about another student? y/n");
                      
                        }

                        else if (moreAnswer == "y" && answer == "favorite food")
                        {
                            Console.WriteLine(classList[studentNum] + " is from  " + homeTown[studentNum] + " and they are " + isCool[studentNum]);
                            Console.WriteLine("Would you like to learn about another student? y/n");
                       
                        }

                        else if (moreAnswer == "n")
                        {

                            Console.WriteLine("Thanks!");
                        }




                        string askAnoStu = Console.ReadLine().ToLower();
                    
                       if (askAnoStu== "n")
                         {
                            anotherStu = false;

                            Console.WriteLine("Thanks!");
                         }

                        else  if (askAnoStu == "y")
                         {
                        anotherStu = true;
                        //loop to top
                         }


                    
                    //COULDN'T GET ELSE STATEMENT FOR WHEN THEY DONT ENTER HOMETOWN OR FAVORITE FOOD RIGHT TO WORK
                    //COULDN"T GET ASK FOR ANOTHER STUDENT LOOP TO WORK


                }

            }
        }
    }
}