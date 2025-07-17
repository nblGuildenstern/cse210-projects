using System;

class Program
{
    static void Main(string[] args)
    {
        long totalGames = 100000000000; //100,000,000,000
        long wins = 0;
        long games = 0;
        Random random = new Random();
        for (long i = 0; i < totalGames; i++)
        {
            int correctDoor = random.Next(1, 4);
            int chosenDoor = random.Next(1, 4);
            int removedDoor = 0;
            switch (chosenDoor)
            {
                case 1:
                    if (correctDoor == 1) {
                        removedDoor = random.Next(2, 4);
                    } else {
                        if (correctDoor == 2) {
                            removedDoor = 3;
                        } else {
                            removedDoor = 2;
                        }
                    }
                    break;
                case 2:
                    if (correctDoor == 2) {
                        removedDoor = (random.Next(1, 3) * 2) - 1;
                    } else {
                        if (correctDoor == 1) {
                            removedDoor = 3;
                        } else {
                            removedDoor = 1;
                        }
                    }
                    break;
                case 3:
                    if (correctDoor == 3) {
                        removedDoor = random.Next(1, 3);
                    } else {
                        if (correctDoor == 1) {
                            removedDoor = 2;
                        } else {
                            removedDoor = 1;
                        }
                    }
                    break;
            }
            switch(removedDoor) {
                case 1:
                    if(chosenDoor == 2) {
                        chosenDoor = 3;
                    } else {
                        chosenDoor = 2;
                    }
                    break;
                case 2:
                    if(chosenDoor == 1) {
                        chosenDoor = 3;
                    } else {
                        chosenDoor = 1;
                    }
                    break;
                case 3:
                    if(chosenDoor == 1) {
                        chosenDoor = 2;
                    } else {
                        chosenDoor = 1;
                    }
                    break;
            }
            games++;
            if(chosenDoor == correctDoor) {
                wins++;
            }
        }
                
        Console.WriteLine("Games: " + games);
        Console.WriteLine("Wins: " + wins);
        Console.WriteLine("Percentage: " + ((double)wins/(double)games));
    }
}