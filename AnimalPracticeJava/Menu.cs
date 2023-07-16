using AnimalPracticeJava;
using System.Text.RegularExpressions;

internal class Menu
{
    private static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("\nChoose an animal:");
            Console.WriteLine("1. Bunny");
            Console.WriteLine("2. Hamster");
            Console.WriteLine("3. Cat");
            Console.WriteLine("4. Fish");
            Console.WriteLine("5. Dog");
            Console.WriteLine("6. Parrot");

            Console.Write("Animal: ");

            int animalChoice;
            try
            {
                string animalInput = Console.ReadLine();

                if(String.IsNullOrEmpty(animalInput))
                {
                    throw new EmptyInputException("Empty input");
                }

                animalChoice = int.Parse(animalInput);

                if(animalChoice < 1 || animalChoice > 6)
                {
                    throw new OutsideRangeException("Enter number within specified range!");
                }
            }
            catch(FormatException ex) {
                errorCheck(ex.Message, ex.Source, ex.StackTrace);
                continue;
            }
            catch(EmptyInputException one)
            {
                errorCheck(one.Message, one.Source, one.StackTrace);
                continue;
            }
            catch(OutsideRangeException one)
            {
                errorCheck(one.Message, one.Source, one.StackTrace);
                continue;
            }


            

            Animal animal;
            string name = "";
            while (string.IsNullOrEmpty(name))
            {
                Console.Write("\nPlease enter a name for your pet: ");               
                try
                {

                    name = Console.ReadLine();
                    if (String.IsNullOrEmpty(name))
                    {
                        throw new EmptyInputException("No input given!");
                    }
                    if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                    {
                        throw new TextOnlyException("Only enter text!");
                    }
                    if(name.Length > 20)
                    {
                        throw new ArgumentOutOfRangeException("name");
                    }


                }
                catch (EmptyInputException two)
                {
                    errorCheck(two.Message, two.Source, two.StackTrace);
                    name = "";
                    continue;
                }
                catch(TextOnlyException one)
                {
                    errorCheck(one.Message, one.Source, one.StackTrace);
                    name = "";
                    continue;
                }
                catch(ArgumentOutOfRangeException one)
                {
                    errorCheck(one.Message, one.Source, one.StackTrace);
                    name = "";
                    continue;
                }
            }
            switch (animalChoice)
            {
                case 1:
                    animal = new Bunny(name);
                    break;
                case 2:
                    animal = new Hamster(name);
                    break;
                case 3:
                    animal = new Cat(name);
                    break;
                case 4:
                    animal = new Fish(name);
                    break;
                case 5:
                    animal = new Dog(name);
                    break;
                case 6:
                    animal = new Parrot(name);
                    break;
                default:
                    Console.WriteLine($"\n{animalChoice} is an invalid choice, please enter a number between 1 and 6");
                        continue;

            }
           
            while (true)
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Sleep");
                Console.WriteLine("2. Eat");
                Console.WriteLine("3. Communicate");
                Console.WriteLine("4. Play");
                Console.WriteLine("5. Display stats");

                int actionChoice;
                try
                {
                    string actionInput = Console.ReadLine();

                    if (String.IsNullOrEmpty(actionInput))
                    {
                        throw new EmptyInputException("Empty input");
                    }

                    actionChoice = int.Parse(actionInput);

                    if (actionChoice < 1 || actionChoice > 5)
                    {
                        throw new OutsideRangeException("Enter number within specified range!");
                    }
                }
                catch (FormatException ex)
                {
                    errorCheck(ex.Message, ex.Source, ex.StackTrace);
                    continue;
                }
                catch (EmptyInputException one)
                {
                    errorCheck(one.Message, one.Source, one.StackTrace);
                    continue;
                }
                catch (OutsideRangeException one)
                {
                    errorCheck(one.Message, one.Source, one.StackTrace);
                    continue;
                }
                switch (actionChoice)
                {
                    case 1:
                        animal.sleep();
                        break;
                    case 2:
                        animal.eat();
                        break;
                    case 3:
                        animal.communicate();
                        break;
                    case 4:
                        animal.play();
                        break;
                    case 5:
                        animal.displayStats();
                        break;
                    default:
                        Console.WriteLine($"{actionChoice} is an invalid choice. Please enter a numbet between 1 and 5.");
                        continue;
                }

                Boolean isDead = animal.checkDeath();

                if(isDead)
                {
                    Console.WriteLine($"{name} has died!");
                    Console.WriteLine("Do you want to continue?\nIf so then please enter either 1 to continue or 2 to exit.");
                    int decision = Convert.ToInt32(Console.ReadLine());
                    if(decision == 1)
                    {
                        break;
                    }
                    else if(decision == 2)
                    {
                        Environment.Exit(0);
                    }
                }

                animal.checkHunger();
                animal.checkHappiness();
                animal.checkEnergy();


            }
        }
    }

    static public void errorCheck(string m, string so, string st)
    {
        Console.WriteLine($"\nMessage: {m}");
        Console.WriteLine($"Source: {so}");
        Console.WriteLine($"StackTrace: {st}");
    }
}