using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Blockbuster
    {
        public static DVD BoondockSaints = new DVD("Boondock Saints", "Action", 96, new List<string> { "The boys go to work. ",
                                                                                         "The boys get jumped in an alley. ",
                                                                                         "They take out the city's trash. ",
                                                                                         "The boys take on the mob. ",
                                                                                         "Reunited and if feels so good. ",
                                                                                         "The boys go to court. "
        });
        public static DVD Hook = new DVD("Hook", "Action/Adventure", 94, new List<string> { "Peter has become a pirate. ",
                                                                              "Peter goes to neverland. ",
                                                                              "Peter learns to fly. ",
                                                                              "Peter takes on captain hook. ",
                                                                              "Peter passes down his legacy. "
        });
        public static DVD Haggard = new DVD("Haggard", "Comedy", 90, new List<string> { "Ryan full of regret. ",
                                                                          "Valo hates inventions. ",
                                                                          "To win a mountainbike made of diamonds is to live. ",
                                                                          "Don Vito eats his grapes. ",
                                                                          "The gang messes with Hellboy. ",
                                                                          "Falcone tests his invention",
                                                                          "Falcone wins the diamond mountainbike",
                                                                          "Ryan finds a new girlfriend"
        });

        public static VHS Aladin = new VHS("Aladin", "Animation", 88, new List<string> { "Diamond in the rough. ",
                                                                           "Meet the princess. ",
                                                                           "Elaborate wedding. ",
                                                                           "Jafar is a douche. ",
                                                                           "Long Live the King! wait wrong movie. ",
                                                                           "Aladin saves the princess, big surprise. "
        });
        public static VHS GrandmasBoy = new VHS("Grandma's Boy", "Comedy", 84, new List<string> { "Testing out some video games. ",
                                                                                    "SHIT'S WEAK! ",
                                                                                    "Sometimes pee is poop. ",
                                                                                    "JD steals some ideas. ",
                                                                                    "Beat JD at his own game. "
        });
        public static VHS Equalibrium = new VHS("Equalibrium", "Action/Drama", 104, new List<string> { "Seek and Destroy the dissenters. ",
                                                                                         "Tread lightly, for you tread on my soul. ",
                                                                                         "Taking on the man with geometry. ",
                                                                                         "I feel the feels yo. ",
                                                                                         "Row row fight the powa"
        });
        public List<Movie> Movies = new List<Movie> { BoondockSaints, Hook, Haggard, Aladin, GrandmasBoy, Equalibrium };

        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"Movie {i + 1}: " +
                    $"{Movies[i].Title}");
            }
        }

        public void CheckOutMovie()
        {
            PrintMovies();
            Console.WriteLine($"Which movie would you like to checkout? ");
            while (true)
            {
                Console.WriteLine($"Enter number 1 - {Movies.Count}");
                string uChoice = Console.ReadLine();
                int uNumChoice = 0;
                int choice = uNumChoice - 1;
                if (int.TryParse(uChoice, out uNumChoice))
                {
                    if (uNumChoice >= 1 && uNumChoice <= Movies.Count)
                    {
                        choice = uNumChoice - 1;
                        Movies[choice].Printinfo();
                        while (true)
                        {
                            Console.WriteLine("Press any key to play movie, or 'S' to stop");
                            string uString = Console.ReadLine().ToUpper();
                            if (uString == "S")
                            {
                                break;
                            }
                            else
                            {
                                if (Movies[choice] is DVD)
                                {
                                    Movies[choice].Play();
                                }
                                else
                                {
                                    Movies[choice].Play();
                                    continue;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid movie number");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number for a movie on the list.");
                    continue;
                }
                break;
            }


        }

        public void ShopAtBlockbuster()
        {

            Console.WriteLine("Welcome to blockbuster timetraveler! Here's a list of movies I have in stock:");
            CheckOutMovie();
            //for (int i = 0; i < Movies.Count; i++)
            //{
            //    Console.WriteLine($"Movie {i + 1}:\n");
            //    Movies[i].Printinfo();
            //}

        }
    }
}
