using System;

namespace numericalGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string display = ("THERE ARE 3 LEVELS, EASY, MEDIUM & HARD" + "\n" + "\n" +
					  "AT EASY:- Users get a chance to guess the number between 1 - 10, and the user gets 6 guesses" + "\n" + "\n" +
					  "MEDIUM:- The users is required to guess the number between 1 - 20, and the user gets 4 guesses" + "\n" + "\n" +
					  "HARD:- users are required to guess between 1 - 50, and they only get 3 guesses" + "\n");

		Console.WriteLine("********************************* WELCOME TO NUMBER GUESSING GAME *********************************" + "\n");
		Console.WriteLine("PLEASE ENTER YOUR NAME TO START PLAYING:- " + "\n");
		string name = Console.ReadLine();
		Console.WriteLine();
		Console.WriteLine("WELCOME  " + name + "\n");
		Console.WriteLine();
		Console.WriteLine(display);
		Console.WriteLine();
        Console.WriteLine(" xxxxxxxxxxxxxxxxxxxxx PLEASE NOTE, THERE ARE 3 LEVELS IN THIS GAME, EASY -> 1 | MEDIUM -> 2 | HARD -> 3 xxxxxxxxxxxxxxxxxxxxx" + "\n");
        Console.WriteLine();
        Console.WriteLine("****************************  ENTTER A NUMERICAL VALUE CORRESPONDING TO THE LEVEL YOU WANNA PLAY FROM 1 | 2 | 3 ****************************************");
		var level = Console.ReadLine();
		int userLevelSelected = int.Parse(level);

		/* Check if user enter the correct level */
		int levelChoice;
		bool checkLevelValue = int.TryParse(level, out levelChoice);

		if(!checkLevelValue){
			Console.WriteLine(name + " PLEASE THAT WAS'NT A NUMERICAL VALUE, PLEASE ENTER A NUMERICAL VALUE TO SELECT YOUR LEVEL CHOICE \n");
			return;
		  }
		/* CHeck ends here */

		/* Code to Generate a Random Number */
		int randomValues(int min, int max){

			Random random = new Random();
			return random.Next(min, max+1);
		}

		/* To generate random number for EASY LEVEL */
		int minValueEasy = 1;
		int maxValueEasy = 10;
        int randomNumberEasy = randomValues(minValueEasy,maxValueEasy);

		/* To generate random number for MEIDUM LEVEL */
		int minValueMedium = 1;
		int maxValueMedium = 20;
        int randomNumberMedium = randomValues(minValueMedium,maxValueMedium);

		/* To generate random number for HARD LEVEL */
		int minValuehard = 1;
		int maxValueHard = 50;
        int randomNumberHard = randomValues(minValuehard,maxValueHard);

		/* ***** EASY LEVEL********
            Users get a chance to guess the number between 1 - 10,
            and the user gets 6 guesses
        */

		if(userLevelSelected == 1){
            //You have six tries as a USER
            Console.WriteLine("******************EASY LEVEL - NUMBER GUESSING GAME***************");
            Console.WriteLine("***************************YOU HAVE 6 CHANCES TO GUESS*************************");
            Console.WriteLine("*********** YOU'RE TO GUESS A NUMBER BETWEEN 1 AND 10 ***\n");
            int guessTry = 5;

				for(int i = 0; i <= guessTry; i++){
					if(i > 0){
						Console.WriteLine(" Hmm!, THAT WAS TOO LOW, BUT LETS TRY AGAIN \n");
					}
					else{ Console.WriteLine("OK, PLEASE ENTER A NUMBER\n"); }

					//Take users GUESS
                    /**
                        Start!
                        check if correct value is entered or anything other than number
                     */

					var yourInput = Console.ReadLine();
					int number;
					bool notInt = int.TryParse(yourInput, out number);

					if(!notInt){
						Console.WriteLine(name + "  PLEASE THAT WAS'NT A NUMERICAL VALUE! ");
						return;
					}
					/* Check Ends */

					int guessedValue = int.Parse(yourInput);
					if(guessedValue < 1 || guessedValue > 10){
						Console.WriteLine("YOU CAN'T PICK A NUMBER LESS THAN 1 OR ABOVE 10");
					}
					if(guessedValue == randomNumberEasy){
						Console.WriteLine("CONGRATULATION! YOU GUESSED RIGHT!");
						if(i < 3){
							Console.WriteLine("AWESOME! MAYBE YOU WANNA TRY MEDIUM LEVEL");
						}
						return;
					}
					if(i == guessTry && guessedValue != randomNumberEasy){
						Console.WriteLine("YOU'VE COME TO THE END OF THE GAME!");
                        Console.WriteLine("***GAME OVER***");
                        Console.WriteLine("THE NUMBER WAS = ***" + randomNumberEasy + "***" );
                        return;
					}
						Console.WriteLine(" OH SORRY, THAT WAS WRONG " + name );
                    	Console.WriteLine(" YOU HAVE "+ (guessTry - i) + " MORE TRIAL(s) to go.");
					}
				}


				/*
                	*****MEDIUM LEVEL********
             	*/

		if(userLevelSelected == 2){
            //You have six tries as a USER
            Console.WriteLine("******************MEDIUM LEVEL - NUMBER GUESSING GAME***************");
            Console.WriteLine("***************************YOU HAVE 4 CHANCES TO GUESS*************************");
            Console.WriteLine("*********** YOU'RE TO GUESS A NUMBER BETWEEN 1 AND 20 ***\n");
            int guessTry = 3;

				for(int i = 0; i <= guessTry; i++){
					if(i > 0){
						Console.WriteLine(" Hmm!, THAT WAS TOO LOW, BUT LETS TRY AGAIN \n");
					}
					else{ Console.WriteLine("OK, PLEASE ENTER A NUMBER\n"); }

					//Take users GUESS
                    /**
                        Start!
                        check if correct value is entered or anything other than number
                     */

					var yourInput = Console.ReadLine();
					int number;
					bool notInt = int.TryParse(yourInput, out number);

					if(!notInt){
						Console.WriteLine(name + "  PLEASE THAT WAS'NT A NUMERICAL VALUE! ");
						return;
					}
					/* Check Ends */

					int guessedValue = int.Parse(yourInput);
					if(guessedValue < 1 || guessedValue > 20){
						Console.WriteLine("YOU CAN'T PICK A NUMBER LESS THAN 1 OR ABOVE 10");
					}
					if(guessedValue == randomNumberMedium){
						Console.WriteLine("CONGRATULATION! YOU GUESSED RIGHT!");
						if(i < 3){
							Console.WriteLine("AWESOME! MAYBE YOU WANNA TRY MEDIUM LEVEL");
						}
						return;
					}
					if(i == guessTry && guessedValue != randomNumberMedium){
						Console.WriteLine("YOU'VE COME TO THE END OF THE GAME!");
                        Console.WriteLine("***GAME OVER***");
                        Console.WriteLine("THE NUMBER WAS = ***" + randomNumberMedium + "***" );
                        return;
					}
						Console.WriteLine(" OH SORRY, THAT WAS WRONG " + name );
                    	Console.WriteLine(" YOU HAVE "+ (guessTry - i) + " MORE TRIAL(s) to go.");
					}
				}

				/*
               		*****HARD LEVEL********
             	*/


		if(userLevelSelected == 3){
            //You have six tries as a USER
            Console.WriteLine("******************HARD LEVEL - NUMBER GUESSING GAME***************");
            Console.WriteLine("***************************YOU HAVE 3 CHANCES TO GUESS*************************");
            Console.WriteLine("*********** YOU'RE TO GUESS A NUMBER BETWEEN 1 AND 50 ***\n");
            int guessTry = 2;

				for(int i = 0; i <= guessTry; i++){
					if(i > 0){
						Console.WriteLine(" Hmm!, THAT WAS TOO LOW, BUT LETS TRY AGAIN \n");
					}
					else{ Console.WriteLine("OK, PLEASE ENTER A NUMBER\n"); }

					//Take users GUESS
                    /**
                        Start!
                        check if correct value is entered or anything other than number
                     */

					var yourInput = Console.ReadLine();
					int number;
					bool notInt = int.TryParse(yourInput, out number);

					if(!notInt){
						Console.WriteLine(name + "  PLEASE THAT WAS'NT A NUMERICAL VALUE! ");
						return;
					}
					/* Check Ends */

					int guessedValue = int.Parse(yourInput);
					if(guessedValue < 1 || guessedValue > 50){
						Console.WriteLine("YOU CAN'T PICK A NUMBER LESS THAN 1 OR ABOVE 10");
					}
					if(guessedValue == randomNumberHard){
						Console.WriteLine("CONGRATULATION! YOU GUESSED RIGHT!");
						if(i < 3){
							Console.WriteLine("AWESOME! MAYBE YOU WANNA TRY MEDIUM LEVEL");
						}
						return;
					}
					if(i == guessTry && guessedValue != randomNumberHard){
						Console.WriteLine("YOU'VE COME TO THE END OF THE GAME!");
                        Console.WriteLine("***GAME OVER***");
                        Console.WriteLine("THE NUMBER WAS = ***" + randomNumberHard + "***" );
                        return;
					}
						Console.WriteLine(" OH SORRY, THAT WAS WRONG " + name );
                    	Console.WriteLine(" YOU HAVE "+ (guessTry - i) + " MORE TRIAL(s) to go.");
					}
				}

				/* END OF MY CODE */
        }
    }
}
