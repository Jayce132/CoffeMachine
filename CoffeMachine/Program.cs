using System;

namespace CoffeMachine
{
    class Program
    {
        static void Main(String[] args)
        {
            int water = 400;
            int milk = 540;
            int beans = 120;
            int cups = 9;
            int money = 550;

            while (true)
            {
                Console.Write("Write action (buy, fill, take, remaining, exit):\n"
                                + "> ");

                String input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "buy":
                        Console.Write("What do you want to buy? "
                                        + "1 - espresso, "
                                        + "2 - latte, "
                                        + "3 - cappuccino, "
                                        + "back - to main menu:\n"
                                        + "> ");

                        String buy = Console.ReadLine();
                        bool missingIngredients = false;

                        switch (buy)
                        {
                            case "1": //espresso
                                if (water - 250 <= 0)
                                {
                                    Console.WriteLine("Sorry, not enough water!");
                                    missingIngredients = true;
                                }
                                if (beans - 16 <= 0)
                                {
                                    Console.WriteLine("Sorry, not enough coffee beans!");
                                    missingIngredients = true;
                                }
                                if (cups - 1 <= 0)
                                {
                                    Console.WriteLine("Sorry, not enough cups!");
                                    missingIngredients = true;
                                }
                                if (missingIngredients == false)
                                {
                                    Console.WriteLine("I have enough resources, "
                                                        + "making you a coffee!\n");
                                    water -= 250;
                                    beans -= 16;
                                    cups--;
                                    money += 4;
                                    break;
                                }
                                Console.WriteLine();
                                break;

                            case "2": //latte
                                if (water - 350 <= 0)
                                {
                                    Console.WriteLine("Sorry, not enough water!");
                                    missingIngredients = true;
                                }
                                if (milk - 75 <= 0)
                                {
                                    Console.WriteLine("Sorry, not enough milk!");
                                    missingIngredients = true;
                                }
                                if (beans - 20 <= 0)
                                {
                                    Console.WriteLine("Sorry, not enough coffee beans!");
                                    missingIngredients = true;
                                }
                                if (cups - 1 <= 0)
                                {
                                    Console.WriteLine("Sorry, not enough cups!");
                                    missingIngredients = true;
                                }
                                if (missingIngredients == false)
                                {
                                    Console.WriteLine("I have enough resources, "
                                                        + "making you a coffee!\n");
                                    water -= 350;
                                    milk -= 75;
                                    beans -= 20;
                                    cups--;
                                    money += 7;
                                    break;
                                }
                                Console.WriteLine();
                                break;

                            case "3": //cappuccino
                                if (water - 200 <= 0)
                                {
                                    Console.WriteLine("Sorry, not enough water!");
                                    missingIngredients = true;
                                }
                                if (milk - 100 <= 0)
                                {
                                    Console.WriteLine("Sorry, not enough milk!");
                                    missingIngredients = true;
                                }
                                if (beans - 12 <= 0)
                                {
                                    Console.WriteLine("Sorry, not enough coffee beans!");
                                    missingIngredients = true;
                                }
                                if (cups - 1 <= 0)
                                {
                                    Console.WriteLine("Sorry, not enough cups!");
                                    missingIngredients = true;
                                }
                                if (missingIngredients == false)
                                {
                                    Console.WriteLine("I have enough resources, "
                                                        + "making you a coffee!\n");
                                    water -= 200;
                                    milk -= 100;
                                    beans -= 12;
                                    cups--;
                                    money += 6;
                                    break;
                                }
                                Console.WriteLine();
                                break;

                            case "back":
                                Console.WriteLine();
                                continue; //back to Write action:
                            default:
                                break;
                        }
                        break;

                    case "fill":
                        Console.Write("Write how many ml of water do you want to add:\n"
                                        + "> ");
                        int addWater = int.Parse(Console.ReadLine());
                        water += addWater;

                        Console.Write("Write how many ml of milk do you want to add:\n"
                                        + "> ");
                        int addMilk = int.Parse(Console.ReadLine());
                        milk += addMilk;

                        Console.Write("Write how many grams of coffee beans do you want to add:\n"
                                        + "> ");
                        int addBeans = int.Parse(Console.ReadLine());
                        beans += addBeans;

                        Console.Write("Write how many disposable cups of coffee do you want to add:\n"
                                        + "> ");
                        int addCups = int.Parse(Console.ReadLine());
                        cups += addCups;
                        Console.Write("\n");
                        break;

                    case "take":
                        Console.WriteLine("I gave you $" + money + "\n");
                        money = 0;
                        break;

                    case "exit":
                        return;

                    case "remaining":
                        Console.WriteLine("The coffee machine has:\n"
                                            + water + " of water\n"
                                            + milk + " of milk\n"
                                            + beans + " of coffee beans\n"
                                            + cups + " of disposable cups\n"
                                            + money + " of money\n");
                        break;
                    default:
                        break;
                }

            }
        }
    }

}
