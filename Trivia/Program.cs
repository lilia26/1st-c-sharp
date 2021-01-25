using System;

namespace Trivia
{
	class Program
	{
		public class Global
		{
			public static int playerId = 0;
			public static string[] playerNames = {"",""};
			public static int[] playerScores = {0,0};
		}

		static void Main(string[] args)
		{
			SetBackground("initial");

			Console.WriteLine("\t\t\tThe Lilia Trivia Game!");
			Console.WriteLine("");
			Console.WriteLine(" This is a two player game that chalenges your trivia skills in various topics.");
			Console.WriteLine(" Have a blast!  Good luck players!");

			Console.WriteLine("");
			Console.WriteLine("Player one, please input your first name:");
			Global.playerNames[0] = Console.ReadLine();
			Console.WriteLine("");
			Console.WriteLine("Player two, please input your first name:");
			Global.playerNames[1] = Console.ReadLine();

			ShowMenu();
		}

		static void SetBackground(string background)
		{
			switch (background)
			{
				case "initial":
					Console.BackgroundColor = ConsoleColor.DarkYellow;
					Console.ForegroundColor = ConsoleColor.White;
					break;
				case "menu":
					Console.BackgroundColor = ConsoleColor.Green;
					Console.ForegroundColor = ConsoleColor.Yellow;
					break;
				case "player0":
					Console.BackgroundColor = ConsoleColor.Blue;
					Console.ForegroundColor = ConsoleColor.White;
					break;
				case "player1":
					Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.White;
					break;
			}
			Console.Clear();
		}
		static void ShowMenu()
		{
			int choice;

			SetBackground("menu");

			for (int i = 0; i < Global.playerNames.Length; i++)
			{
				Console.WriteLine("{0}, Score = {1}", Global.playerNames[i], Global.playerScores[i]);
				Console.WriteLine("");
			}
			Console.WriteLine("\t\tMenu");
			Console.WriteLine("");
			Console.WriteLine("1. Ornithology");
			Console.WriteLine("2. Fossils");
			Console.WriteLine("3. Music");
			Console.WriteLine("4. Capitals");
			Console.WriteLine("5. Miscellaneous");
			Console.WriteLine("6. Exit the program");
			Console.WriteLine("\n\n");

			Console.WriteLine("{0}, please select a number from the menu:", Global.playerNames[Global.playerId]);
			choice = int.Parse(Console.ReadLine());

			SetBackground("player" + Global.playerId);

			switch (choice)
			{
				case 1:
					PlayOrnithology();
					NextTurn();
					break;
				case 2:
					PlayFossils();
					NextTurn();
					break;
				case 3:
					PlayMusic();
					NextTurn();
					break;
				case 4:
					PlayCapitals();
					NextTurn();
					break;
				case 5:
					PlayMiscellaneous();
					NextTurn();
					break;
				case 6:
					exit();
					break;
				default:
					ShowMenu();
					break;
			}
		}
		static int GetRandomNumber()
		{
			Random randoms = new Random();
			return randoms.Next(1, 31);
		}
		static void AddPoint()
		{
			Console.WriteLine(Global.playerNames[Global.playerId] + " you are correct!");
			Global.playerScores[Global.playerId]++;
			Console.ReadLine();
		}

		static void NextTurn()
		{
			Global.playerId++;
			if (Global.playerId == Global.playerNames.Length)
			{
				Global.playerId = 0;
			}
			ShowMenu();
		}

		static void PlayOrnithology()
		{
			int correctAnswer = 0;

			Console.WriteLine(Global.playerNames[Global.playerId] + " Your Topic is Ornithology");
			Console.WriteLine("\n");

			switch (GetRandomNumber())
			{
				case 1:
					Console.WriteLine("Which of the following birds does NOT perform brood parasitism?");
					Console.WriteLine("");
					Console.WriteLine("1. Brown-headed Cowbird");
					Console.WriteLine("2. House Sparrow");
					Console.WriteLine("3. Hooded Merganser");
					Console.WriteLine("4. Black-billed Cuckoo");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 2:
					Console.WriteLine("What is the scientific name of an Anhinga?");
					Console.WriteLine("");
					Console.WriteLine("1. Anhinga auritus");
					Console.WriteLine("2. Platea anhinga");
					Console.WriteLine("3. Anhinga anhinga");
					Console.WriteLine("4. Phalacrocorax auritus");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 3:
					Console.WriteLine("Hummingbirds do all of the following except");
					Console.WriteLine("");
					Console.WriteLine("1. Can walk");
					Console.WriteLine("2. Fly backwards");
					Console.WriteLine("3. Drink nectar");
					Console.WriteLine("4. Fly with very fast speed");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 4:
					Console.WriteLine("How many birds are there in the world? How many species of birds are there?");
					Console.WriteLine("");
					Console.WriteLine("1. 3 billion birds; 10,000 species");
					Console.WriteLine("2. 3 billion birds, 5,000 species");
					Console.WriteLine("3. 5 billion birds; 10,000 species");
					Console.WriteLine("4. 5 billion species; 5,000 species");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 5:
					Console.WriteLine("What is the difference between stripes and bars when discussing plumage patterns?");
					Console.WriteLine("");
					Console.WriteLine("1. There is no difference");
					Console.WriteLine("2. Stripes have to do with plumage but bars don't");
					Console.WriteLine("3. Bars are head-to-head / lengthwise while stripes are wing-to-wing / across");
					Console.WriteLine("4. Stripes are head-to-head / lengthwise while bars are wing-to-wing / across");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 6:
					Console.WriteLine("Which of the following is NOT part of a bird wing?");
					Console.WriteLine("");
					Console.WriteLine("1. Shoulder");
					Console.WriteLine("2. Lores");
					Console.WriteLine("3. Axillaries");
					Console.WriteLine("4. Primaries");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 7:
					Console.WriteLine("Which is NOT a foot adaptation?");
					Console.WriteLine("");
					Console.WriteLine("1. Preying");
					Console.WriteLine("2. Perching");
					Console.WriteLine("3. Mating");
					Console.WriteLine("4. Swimming");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 8:
					Console.WriteLine("Most of the body weight is made up of...?");
					Console.WriteLine("");
					Console.WriteLine("1. Flight muscles");
					Console.WriteLine("2. Hollow bone");
					Console.WriteLine("3. Bill");
					Console.WriteLine("4. Feathers");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 9:
					Console.WriteLine("What is the most important sense?");
					Console.WriteLine("");
					Console.WriteLine("1. Sight");
					Console.WriteLine("2. Smell");
					Console.WriteLine("3. Sound");
					Console.WriteLine("4. Touch");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 10:
					Console.WriteLine("In what type of nest do woodpeckers lay eggs?");
					Console.WriteLine("");
					Console.WriteLine("1. None, they are brood parasites");
					Console.WriteLine("2. A secluded place");
					Console.WriteLine("3. Burrow");
					Console.WriteLine("4. Cavity");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 11:
					Console.WriteLine("Which of these is NOT contributing to population declines?");
					Console.WriteLine("");
					Console.WriteLine("1. Habitat loss");
					Console.WriteLine("2. Rising water levels");
					Console.WriteLine("3. Pollution");
					Console.WriteLine("4. Agriculture");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 12:
					Console.WriteLine("Which of these is in the Passeriformes order?");
					Console.WriteLine("");
					Console.WriteLine("1. Roseate Spoonbill");
					Console.WriteLine("2. Greater Roadrunner");
					Console.WriteLine("3. Spotted Towhee");
					Console.WriteLine("4. Ruddy Turnstone");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 13:
					Console.WriteLine("What is a gizzard?");
					Console.WriteLine("");
					Console.WriteLine("1. A structure composed of tough muscle tissue");
					Console.WriteLine("2. Allows waste to be expelled from the bird's body");
					Console.WriteLine("3. A long tube that runs from the bird's throat to its lungs");
					Console.WriteLine("4. Composed layers of muscle tissues that holds food");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 14:
					Console.WriteLine("What allows waste to be expelled from the bird's body?");
					Console.WriteLine("");
					Console.WriteLine("1. Rectum");
					Console.WriteLine("2. Crop");
					Console.WriteLine("3. Esophagus");
					Console.WriteLine("4. Trachea");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 15:
					Console.WriteLine("What isn't part of a bird's skeleton?");
					Console.WriteLine("");
					Console.WriteLine("1. Pelvic Girdle");
					Console.WriteLine("2. Keel");
					Console.WriteLine("3. Scapula");
					Console.WriteLine("4. Ureter");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 16:
					Console.WriteLine("Which fact about birds is false?");
					Console.WriteLine("");
					Console.WriteLine("1. All extant birds have forearms adapted for flight knows as wings");
					Console.WriteLine("2. Lamellae is a chemical that keeps the liquids in a bird stable");
					Console.WriteLine("3. Air sacks are structures unique to birds");
					Console.WriteLine("4. Birds have one of the most efficient respiratory system");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 17:
					Console.WriteLine("Define topography");
					Console.WriteLine("");
					Console.WriteLine("1. A bird's respiratory system and how it works");
					Console.WriteLine("2. The internal anatomy of a bird");
					Console.WriteLine("3. The external anatomy of a bird");
					Console.WriteLine("4. The circulation and how it works");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 18:
					Console.WriteLine("What are bird's wings made up of?");
					Console.WriteLine("");
					Console.WriteLine("1. B-keratin");
					Console.WriteLine("2. Zygomatic");
					Console.WriteLine("3. Lek");
					Console.WriteLine("4. Cere");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 19:
					Console.WriteLine("What is Zygomatic?");
					Console.WriteLine("");
					Console.WriteLine("1. Cheek bone");
					Console.WriteLine("2. Upper beak");
					Console.WriteLine("3. Keratinized covering of beak");
					Console.WriteLine("4. Thin rods and plates of bone tissue that connects holes in bones");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 20:
					Console.WriteLine("Flight feathers are specialized _____ feathers");
					Console.WriteLine("");
					Console.WriteLine("1. Down");
					Console.WriteLine("2. Vaned");
					Console.WriteLine("3. Filoplumes");
					Console.WriteLine("4. Contour");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 21:
					Console.WriteLine("Define trabeculae");
					Console.WriteLine("");
					Console.WriteLine("1. A fibrous protein forming the main structural constituent of feathers");
					Console.WriteLine("2. Thin rods and plates of bone tissue that connects holes in bones");
					Console.WriteLine("3. Forms the lateral wall of the nasopharynx");
					Console.WriteLine("4. The upper margin of the beak or bill");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 22:
					Console.WriteLine("What isn't a name of an air sack in a bird?");
					Console.WriteLine("");
					Console.WriteLine("1. Posterior");
					Console.WriteLine("2. Lungs");
					Console.WriteLine("3. Cloaea");
					Console.WriteLine("4. Ventrobronchi");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 23:
					Console.WriteLine("How much do the air sacs of birds take up in their bodies?");
					Console.WriteLine("");
					Console.WriteLine("1. 7%");
					Console.WriteLine("2. 20%");
					Console.WriteLine("3. 35%");
					Console.WriteLine("4. 86%");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 24:
					Console.WriteLine("What is the most major type of a feather in a bird?");
					Console.WriteLine("");
					Console.WriteLine("1. Contour Feather");
					Console.WriteLine("2. Filoplumes Feather");
					Console.WriteLine("3. Flight Feather");
					Console.WriteLine("4. Semiplumes Feather");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 25:
					Console.WriteLine("About how many bird families are there?");
					Console.WriteLine("");
					Console.WriteLine("1. 250");
					Console.WriteLine("2. 234");
					Console.WriteLine("3. 185");
					Console.WriteLine("4. 170");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 26:
					Console.WriteLine("How many heart chambers does a bird have?");
					Console.WriteLine("");
					Console.WriteLine("1. 1");
					Console.WriteLine("2. 2");
					Console.WriteLine("3. 3");
					Console.WriteLine("4. 4");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 27:
					Console.WriteLine("How many wrist bones do birds have?");
					Console.WriteLine("");
					Console.WriteLine("1. 1");
					Console.WriteLine("2. 2");
					Console.WriteLine("3. 3");
					Console.WriteLine("4. 4");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 28:
					Console.WriteLine("How many air sacs are in a bird?");
					Console.WriteLine("");
					Console.WriteLine("1. 4");
					Console.WriteLine("2. 9");
					Console.WriteLine("3. 11");
					Console.WriteLine("4. 23");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 29:
					Console.WriteLine("What does Auricle Region mean?");
					Console.WriteLine("");
					Console.WriteLine("1. Ear tufts");
					Console.WriteLine("2. Lores");
					Console.WriteLine("3. Crest");
					Console.WriteLine("4. Cere");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 30:
					Console.WriteLine("What does Buteo mean?");
					Console.WriteLine("");
					Console.WriteLine("1. Grounded living birds");
					Console.WriteLine("2. Birds that captures prey");
					Console.WriteLine("3. Birds that don't travel on ground");
					Console.WriteLine("4. A type of raptor with broad wings");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				default:
					break;
			}
			if (int.Parse(Console.ReadLine()) == correctAnswer)
			{
				AddPoint();
			}
		}
		static void PlayFossils()
		{
			int correctAnswer = 0;

			Console.WriteLine(Global.playerNames[Global.playerId] + " Your Topic is Fossils");
			Console.WriteLine("\n");

			switch (GetRandomNumber())
			{
				case 1:
					Console.WriteLine("The word dinosaur means…");
					Console.WriteLine("");
					Console.WriteLine("1. Ferocious animal");
					Console.WriteLine("2. Terrible lizard");
					Console.WriteLine("3. Angry reptile");
					Console.WriteLine("4. Large reptile");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 2:
					Console.WriteLine("During which period did dinosaurs first appear?");
					Console.WriteLine("");
					Console.WriteLine("1. Permian");
					Console.WriteLine("2. Jurassic");
					Console.WriteLine("3. Triassic");
					Console.WriteLine("4. Neolithic");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 3:
					Console.WriteLine("For what was Robert Plot known?");
					Console.WriteLine("");
					Console.WriteLine("1. He found a bone believing it belonged to a giant person.");
					Console.WriteLine("2. He was a paleontologist who lived in the late 19th century.");
					Console.WriteLine("3. He found a giant fish bone in 1676.");
					Console.WriteLine("4. He was a famed paleontologist who identified the T. rex");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 4:
					Console.WriteLine("In 1822, what was discovered in England by Mary Ann Mantell and her husband, Gideon Mantell?");
					Console.WriteLine("");
					Console.WriteLine("1. Large teeth");
					Console.WriteLine("2. Leg bone");
					Console.WriteLine("3. Arm bone");
					Console.WriteLine("4. Dinosaur skin");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 5:
					Console.WriteLine("When did dinosaurs become extinct?");
					Console.WriteLine("");
					Console.WriteLine("1. 475 million years ago");
					Console.WriteLine("2. 250 million years ago");
					Console.WriteLine("3. 65 billion years ago");
					Console.WriteLine("4. 65 million years ago");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 6:
					Console.WriteLine("What was the first dinosaur fossil ever found on earth?");
					Console.WriteLine("");
					Console.WriteLine("1. Potatosaurus");
					Console.WriteLine("2. Megalosaurus");
					Console.WriteLine("3. Thesaurus");
					Console.WriteLine("4. Stegosaurus");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 7:
					Console.WriteLine("What is the biggest fossil ever found?");
					Console.WriteLine("");
					Console.WriteLine("1. Diplodocus");
					Console.WriteLine("2. Brontosaurus");
					Console.WriteLine("3. Tyrannosaurus");
					Console.WriteLine("4. Argentinosaurus");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 8:
					Console.WriteLine("What is the name of the oldest human fossil ever found?");
					Console.WriteLine("");
					Console.WriteLine("1. Lucy");
					Console.WriteLine("2. Cindy");
					Console.WriteLine("3. Bob");
					Console.WriteLine("4. Joe");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 9:
					Console.WriteLine("What is the oldest fossil that we found to this date?");
					Console.WriteLine("");
					Console.WriteLine("1. Stromatolites");
					Console.WriteLine("2. Archimedes");
					Console.WriteLine("3. Eurypterida");
					Console.WriteLine("4. Parasaurolophus");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 10:
					Console.WriteLine("What was the bite force of a Dunkleosteus?");
					Console.WriteLine("");
					Console.WriteLine("1. 50,000 N");
					Console.WriteLine("2. 10,000 N");
					Console.WriteLine("3. 7,000 N");
					Console.WriteLine("4. 6,000 N");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 11:
					Console.WriteLine("When did Order Fusulinida (Fusulinids) become extinct?");
					Console.WriteLine("");
					Console.WriteLine("1. Silurian - Devonian");
					Console.WriteLine("2. Permian - Triassic");
					Console.WriteLine("3. Eocene Epoch - Paleogene");
					Console.WriteLine("4. Devonian - Present");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 12:
					Console.WriteLine("What is not part of the Bryozoa growth formation?");
					Console.WriteLine("");
					Console.WriteLine("1. Branching");
					Console.WriteLine("2. Fenestrate");
					Console.WriteLine("3. Ordovician");
					Console.WriteLine("4. Massive");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 13:
					Console.WriteLine("What are dinosaur eggs classified into?");
					Console.WriteLine("");
					Console.WriteLine("1. Oogenera");
					Console.WriteLine("2. Allosterics");
					Console.WriteLine("3. Spherulitic");
					Console.WriteLine("4. Cathodoluminescence");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 14:
					Console.WriteLine("When did the first life forms appear on earth?");
					Console.WriteLine("");
					Console.WriteLine("1. 4.28 Billion Years Ago");
					Console.WriteLine("2. 3.96 Billion years ago");
					Console.WriteLine("3. 8.39 Billion Years Ago");
					Console.WriteLine("4. 36.73 Million Years Ago");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 15:
					Console.WriteLine("What adaptation allowed reptiles to become dominant on land?");
					Console.WriteLine("");
					Console.WriteLine("1. Lophophore");
					Console.WriteLine("2. Miocene");
					Console.WriteLine("3. Foraminifera");
					Console.WriteLine("4. Amniotic Egg");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 16:
					Console.WriteLine("What is the New York state fossil?");
					Console.WriteLine("");
					Console.WriteLine("1. Calymene");
					Console.WriteLine("2. Eurypterida");
					Console.WriteLine("3. Septastraea");
					Console.WriteLine("4. Nummulites");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 17:
					Console.WriteLine("Define extant");
					Console.WriteLine("");
					Console.WriteLine("1. Lived in both land and water");
					Console.WriteLine("2. From thousands for years ago");
					Console.WriteLine("3. Still in existence and widespread");
					Console.WriteLine("4. Founded in tar pits");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 18:
					Console.WriteLine("Where is the La Brea Tar Pits found?");
					Console.WriteLine("");
					Console.WriteLine("1. California");
					Console.WriteLine("2. New York");
					Console.WriteLine("3. North Dakota");
					Console.WriteLine("4. Colorado");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 19:
					Console.WriteLine("What is Radiometric dating?");
					Console.WriteLine("");
					Console.WriteLine("1. How to figure out how old fossil remains are");
					Console.WriteLine("2. To figure how far down in the levels of Earth the fossil was found");
					Console.WriteLine("3. How to find out what the fossil ate");
					Console.WriteLine("4. Finding out where the fossil died and how");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 20:
					Console.WriteLine("When was the first turtle fossil found?");
					Console.WriteLine("");
					Console.WriteLine("1. Devonian Period, about 375");
					Console.WriteLine("2. Cretaceous Period, about 920");
					Console.WriteLine("3. Jurassic Period, about 120");
					Console.WriteLine("4. Triassic Period, about 220");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 21:
					Console.WriteLine("Who found the first fossil?");
					Console.WriteLine("");
					Console.WriteLine("1. Mary Anning");
					Console.WriteLine("2. Robert Plot");
					Console.WriteLine("3. Richard Owen");
					Console.WriteLine("4. Barnum Brown");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 22:
					Console.WriteLine("Who named the Allosaurus, Stegosaurus, and Triceratops?");
					Console.WriteLine("");
					Console.WriteLine("1. Edward Drinker Cope");
					Console.WriteLine("2. Cosimo Collini");
					Console.WriteLine("3. Othniel C. Marsh");
					Console.WriteLine("4. Carl Linnaeus");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 23:
					Console.WriteLine("What was the first fossil ever found?");
					Console.WriteLine("");
					Console.WriteLine("1. Thigh bone");
					Console.WriteLine("2. Hip bone");
					Console.WriteLine("3. Leg bone");
					Console.WriteLine("4. Arm bone");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 24:
					Console.WriteLine("Which is not a trace fossil?");
					Console.WriteLine("");
					Console.WriteLine("1. Terrestrials");
					Console.WriteLine("2. Borings");
					Console.WriteLine("3. Tubes");
					Console.WriteLine("4. Trails");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 25:
					Console.WriteLine("What is fossilized poop?");
					Console.WriteLine("");
					Console.WriteLine("1. Predation marks");
					Console.WriteLine("2. Repair scars");
					Console.WriteLine("3. Trackways");
					Console.WriteLine("4. Coprolites");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 26:
					Console.WriteLine("How old is the oldest life remains?");
					Console.WriteLine("");
					Console.WriteLine("1. 1,297 MYA");
					Console.WriteLine("2. 3,480 MYA");
					Console.WriteLine("3. 5,623 MYA");
					Console.WriteLine("4. 7,530 MYA");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 27:
					Console.WriteLine("What are the most common fossils?");
					Console.WriteLine("");
					Console.WriteLine("1. Tissue Fossils");
					Console.WriteLine("2. Anatomy fossils");
					Console.WriteLine("3. Trace fossils");
					Console.WriteLine("4. Skeleton fossils");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 28:
					Console.WriteLine("How many kingdoms do fossils fall into?");
					Console.WriteLine("");
					Console.WriteLine("1. 4");
					Console.WriteLine("2. 5");
					Console.WriteLine("3. 6");
					Console.WriteLine("4. 7");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 29:
					Console.WriteLine("What does Mode of Life mean?");
					Console.WriteLine("");
					Console.WriteLine("1. Essential features of the particular socioeconomic formation");
					Console.WriteLine("2. Product of food through photosynthesis");
					Console.WriteLine("3. Derive nutrition from other organisms without killing them");
					Console.WriteLine("4. Filter small food particles from the water");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 30:
					Console.WriteLine("Dinosaurs are the ancestors of which modern-day animal?");
					Console.WriteLine("");
					Console.WriteLine("1. Mammals");
					Console.WriteLine("2. Insects");
					Console.WriteLine("3. Fish");
					Console.WriteLine("4. Birds");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				default:
					break;
			}
			if (int.Parse(Console.ReadLine()) == correctAnswer)
			{
				AddPoint();
			}
		}
		static void PlayMusic()
		{
			int correctAnswer = 0;

			Console.WriteLine(Global.playerNames[Global.playerId] + " Your Topic is Fossils");
			Console.WriteLine("\n");

			switch (GetRandomNumber())
			{
				case 1:
					Console.WriteLine("Rock band AC/DC actually originates from which country?");
					Console.WriteLine("");
					Console.WriteLine("1. Germany");
					Console.WriteLine("2. Australia");
					Console.WriteLine("3. France");
					Console.WriteLine("4. UK");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 2:
					Console.WriteLine("The Rock and Roll Hall of Fame is situated in what US State?");
					Console.WriteLine("");
					Console.WriteLine("1. Idaho");
					Console.WriteLine("2. California");
					Console.WriteLine("3. Ohio");
					Console.WriteLine("4. New York");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 3:
					Console.WriteLine("Where is Kanye West from?");
					Console.WriteLine("");
					Console.WriteLine("1. Chicago, IL");
					Console.WriteLine("2. New York, NY");
					Console.WriteLine("3. Los Angeles, CA");
					Console.WriteLine("4. Detroit, MI");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 4:
					Console.WriteLine("What musician was deported from Japan in the 1980s for possession of marijuana?");
					Console.WriteLine("");
					Console.WriteLine("1. Paul McCartney");
					Console.WriteLine("2. Stuart Sutcliffe");
					Console.WriteLine("3. Ringo Starr");
					Console.WriteLine("4. John Lennon");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 5:
					Console.WriteLine("What was Elvis Presley’s first hit in 1956?");
					Console.WriteLine("");
					Console.WriteLine("1. “500 Miles”");
					Console.WriteLine("2. “After Loving You”");
					Console.WriteLine("3. “Heartbreak Hotel”");
					Console.WriteLine("4. “Suspicious Minds”");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 6:
					Console.WriteLine("Which singer is a godmother to Elton John’s two sons?");
					Console.WriteLine("");
					Console.WriteLine("1. Halsey");
					Console.WriteLine("2. Lady Gaga");
					Console.WriteLine("3. Selena Gomez");
					Console.WriteLine("4. Dua Lipa");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 7:
					Console.WriteLine("What was the title of the autobiography Diana Ross published in 1994?");
					Console.WriteLine("");
					Console.WriteLine("1. Secrets Of A Flycatcher");
					Console.WriteLine("2. Secrets Of A Swallow");
					Console.WriteLine("3. Secrets Of A Sparrow");
					Console.WriteLine("4. Secrets Of A Warbler");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 8:
					Console.WriteLine("Who raps on Usher’s “Yeah”?");
					Console.WriteLine("");
					Console.WriteLine("1. Ludacris");
					Console.WriteLine("2. Jay-Z");
					Console.WriteLine("3. 50 Cent");
					Console.WriteLine("4. Nas");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 9:
					Console.WriteLine("What pop singer is known as “The Material Girl”?");
					Console.WriteLine("");
					Console.WriteLine("1. Madonna");
					Console.WriteLine("2. Beyoncé");
					Console.WriteLine("3. Lady Gaga");
					Console.WriteLine("4. Adele");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 10:
					Console.WriteLine("Which Beatle had Dyslexia?");
					Console.WriteLine("");
					Console.WriteLine("1. Pete Best");
					Console.WriteLine("2. George Harrison");
					Console.WriteLine("3. Stuart Sutcliffe");
					Console.WriteLine("4. John Lennon");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 11:
					Console.WriteLine("On what date did MTV make its debut?");
					Console.WriteLine("");
					Console.WriteLine("1. August 1st, 1981");
					Console.WriteLine("2. August 1st, 1982");
					Console.WriteLine("3. August 1st, 1983");
					Console.WriteLine("4. August 1st, 1984");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 12:
					Console.WriteLine("Which of these R&B artists did the title track for the movie “Ghostbusters”?");
					Console.WriteLine("");
					Console.WriteLine("1. Elle King");
					Console.WriteLine("2. Dave Bassett");
					Console.WriteLine("3. Ray Parker, Jr.");
					Console.WriteLine("4. Trombone");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 13:
					Console.WriteLine("The Spice Girls released their debut album in 1996. What was the name of the album?");
					Console.WriteLine("");
					Console.WriteLine("1. Spice");
					Console.WriteLine("2. Spiceworld");
					Console.WriteLine("3. Stop");
					Console.WriteLine("4. Forever");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 14:
					Console.WriteLine("Who won the top R&B Male Artist at the Billboard Music Awards 2018?");
					Console.WriteLine("");
					Console.WriteLine("1. Bruno Mars");
					Console.WriteLine("2. Justin Bieber");
					Console.WriteLine("3. Justin Timberlake");
					Console.WriteLine("4. Pitbull");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 15:
					Console.WriteLine("How many members are there in the band Rascal Flatts?");
					Console.WriteLine("");
					Console.WriteLine("1. 1");
					Console.WriteLine("2. 2");
					Console.WriteLine("3. 3");
					Console.WriteLine("4. 4");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 16:
					Console.WriteLine("What was Elvis Presley’s middle name?");
					Console.WriteLine("");
					Console.WriteLine("1. John");
					Console.WriteLine("2. Aaron");
					Console.WriteLine("3. Bobby");
					Console.WriteLine("4. James");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 17:
					Console.WriteLine("In Taylor Swift’s music video “You Need to Calm Down,” what are her and Katy Perry dressed as?");
					Console.WriteLine("");
					Console.WriteLine("1. Cookies and Milk");
					Console.WriteLine("2. Bowl and Cereal");
					Console.WriteLine("3. Fries and Burger");
					Console.WriteLine("4. Turkey and Potato");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 18:
					Console.WriteLine("Who sang “(You Make Me Feel Like) A Natural Woman” at Aretha Franklin’s funeral?");
					Console.WriteLine("");
					Console.WriteLine("1. Ariana Grande");
					Console.WriteLine("2. Tina Turner");
					Console.WriteLine("3. Katy Perry");
					Console.WriteLine("4. Mariah Carey");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 19:
					Console.WriteLine("What show fostered young talents like Justin Timberlake, Britney Spears, and Christina Aguilera before they even became pop stars?");
					Console.WriteLine("");
					Console.WriteLine("1. The Mickey Mouse Club");
					Console.WriteLine("2. Barney & Friends");
					Console.WriteLine("3. Sesame Street");
					Console.WriteLine("4. Loud House");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 20:
					Console.WriteLine("In what country was Alanis Morissette born?");
					Console.WriteLine("");
					Console.WriteLine("1. America");
					Console.WriteLine("2. UK");
					Console.WriteLine("3. German ");
					Console.WriteLine("4. Canada");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 21:
					Console.WriteLine("Thomas Dolby released the song “She Blinded Me With…” What is the ending of this song title?");
					Console.WriteLine("");
					Console.WriteLine("1. Math");
					Console.WriteLine("2. Science");
					Console.WriteLine("3. English");
					Console.WriteLine("4. History");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 22:
					Console.WriteLine("Who was the original lead singer with The Supremes?");
					Console.WriteLine("");
					Console.WriteLine("1. Cindy Birdsong");
					Console.WriteLine("2. Mary Wilson");
					Console.WriteLine("3. Diana Ross");
					Console.WriteLine("4. Jean Terrell");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 23:
					Console.WriteLine("The music video for “Birthday” features Katy Perry disguised as how many different characters in birthday parties?");
					Console.WriteLine("");
					Console.WriteLine("1. 5");
					Console.WriteLine("2. 6");
					Console.WriteLine("3. 7");
					Console.WriteLine("4. 8");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 24:
					Console.WriteLine("What instrument does Jamie Foxx play?");
					Console.WriteLine("");
					Console.WriteLine("1. Piano");
					Console.WriteLine("2. Cello");
					Console.WriteLine("3. Violin");
					Console.WriteLine("4. Trumpet");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 25:
					Console.WriteLine("What singer wrote and performed the song “Mean”?");
					Console.WriteLine("");
					Console.WriteLine("1. Ariana Grande");
					Console.WriteLine("2. Selena Gomez");
					Console.WriteLine("3. Demi Lovato");
					Console.WriteLine("4. Taylor Swift");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 26:
					Console.WriteLine("Which female artist released the song “Hero” in 1993?");
					Console.WriteLine("");
					Console.WriteLine("1. Taylor Swift");
					Console.WriteLine("2. Mariah Carey");
					Console.WriteLine("3. Christina Aguilera");
					Console.WriteLine("4. P!nk");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 27:
					Console.WriteLine("Who sings the song with the lyrics ‘Push me up against the wall, young Kentucky girl in a push-up bra’?");
					Console.WriteLine("");
					Console.WriteLine("1. Red Hot Peppers");
					Console.WriteLine("2. Hot Chili Peppers");
					Console.WriteLine("3. Red Hot Chili Peppers");
					Console.WriteLine("4. Red Chili Peppers");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 28:
					Console.WriteLine("What band has Patrick Stump as lead vocalist and rhythm guitarist?");
					Console.WriteLine("");
					Console.WriteLine("1. Fall Out Boys");
					Console.WriteLine("2. Maroon 5");
					Console.WriteLine("3. 5 Seconds of Summer");
					Console.WriteLine("4. DNCE");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 29:
					Console.WriteLine("What decade is the hit single “November Rain” by Guns N’ Roses from?!");
					Console.WriteLine("");
					Console.WriteLine("1. 1980s");
					Console.WriteLine("2. 1990s");
					Console.WriteLine("3. 2000s");
					Console.WriteLine("4. 2010s");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 30:
					Console.WriteLine("Which band sings the song ‘Barbie Girl’?");
					Console.WriteLine("");
					Console.WriteLine("1. Bowl");
					Console.WriteLine("2. Train");
					Console.WriteLine("3. Queen");
					Console.WriteLine("4. Aqua");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				default:
					break;
			}
			if (int.Parse(Console.ReadLine()) == correctAnswer)
			{
				AddPoint();
			}
		}
		static void PlayCapitals()
		{
			int correctAnswer = 0;

			Console.WriteLine(Global.playerNames[Global.playerId] + " Your Topic is Capitals");
			Console.WriteLine("\n");

			switch (GetRandomNumber())
			{
				case 1:
					Console.WriteLine("The capital of Italy is");
					Console.WriteLine("");
					Console.WriteLine("1. Venice");
					Console.WriteLine("2. Rome");
					Console.WriteLine("3. Naples");
					Console.WriteLine("4. Florence");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 2:
					Console.WriteLine("The capital of Argentina is");
					Console.WriteLine("");
					Console.WriteLine("1. Mendoza");
					Console.WriteLine("2. Rosario");
					Console.WriteLine("3. Buenos Aires");
					Console.WriteLine("4. Córdoba");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 3:
					Console.WriteLine("The capital of Australia is");
					Console.WriteLine("");
					Console.WriteLine("1. Canberra");
					Console.WriteLine("2. Sydney");
					Console.WriteLine("3. Newcastle");
					Console.WriteLine("4. Perth");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 4:
					Console.WriteLine("The capital of Egypt is");
					Console.WriteLine("");
					Console.WriteLine("1. Cairo");
					Console.WriteLine("2. Luxor");
					Console.WriteLine("3. Alexandria");
					Console.WriteLine("4. Aswan");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 5:
					Console.WriteLine("The capital of China is");
					Console.WriteLine("");
					Console.WriteLine("1. Shanghai");
					Console.WriteLine("2. Chongqing");
					Console.WriteLine("3. Tianjin");
					Console.WriteLine("4. Beijing ");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 6:
					Console.WriteLine("The capital of Canada is");
					Console.WriteLine("");
					Console.WriteLine("1. Toronto");
					Console.WriteLine("2. Ottawa");
					Console.WriteLine("3. Montreal");
					Console.WriteLine("4. Vancouver");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 7:
					Console.WriteLine("The capital of India is");
					Console.WriteLine("");
					Console.WriteLine("1. Mumbai");
					Console.WriteLine("2. Bengaluru");
					Console.WriteLine("3. New Delhi");
					Console.WriteLine("4. Chennai");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 8:
					Console.WriteLine("The capital of France is");
					Console.WriteLine("");
					Console.WriteLine("1. Paris");
					Console.WriteLine("2. Bordeaux");
					Console.WriteLine("3. Marseille");
					Console.WriteLine("4. Lyon");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 9:
					Console.WriteLine("The capital of Brazil is");
					Console.WriteLine("");
					Console.WriteLine("1. Brasilia");
					Console.WriteLine("2. Rio de Janeiro");
					Console.WriteLine("3. São Paulo");
					Console.WriteLine("4. Salvador");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 10:
					Console.WriteLine("The capital of Russia is");
					Console.WriteLine("");
					Console.WriteLine("1. Sochi");
					Console.WriteLine("2. Saint Petersburg");
					Console.WriteLine("3. Yekaterinburg");
					Console.WriteLine("4. Moscow");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 11:
					Console.WriteLine("The capital of Germany is");
					Console.WriteLine("");
					Console.WriteLine("1. Munich");
					Console.WriteLine("2. Berlin");
					Console.WriteLine("3. Frankfurt");
					Console.WriteLine("4. Hamburg");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 12:
					Console.WriteLine("The capital of Peru is");
					Console.WriteLine("");
					Console.WriteLine("1. Cusco");
					Console.WriteLine("2. Arequipa");
					Console.WriteLine("3. Lima");
					Console.WriteLine("4. Huancayo");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 13:
					Console.WriteLine("The capital of Ukraine is!");
					Console.WriteLine("");
					Console.WriteLine("1. Kyiv");
					Console.WriteLine("2. Odesa");
					Console.WriteLine("3. Kharkiv");
					Console.WriteLine("4. Lviv");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 14:
					Console.WriteLine("The capital of Spain is");
					Console.WriteLine("");
					Console.WriteLine("1. Madrid");
					Console.WriteLine("2. Barcelona");
					Console.WriteLine("3. Seville");
					Console.WriteLine("4. Granada");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 15:
					Console.WriteLine("The capital of Cuba is");
					Console.WriteLine("");
					Console.WriteLine("1. Santa Clara");
					Console.WriteLine("2. Santiago de Cuba");
					Console.WriteLine("3. Baracoa");
					Console.WriteLine("4. Havana");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 16:
					Console.WriteLine("The capital of Mexico is");
					Console.WriteLine("");
					Console.WriteLine("1. Cancún");
					Console.WriteLine("2. Mexico City");
					Console.WriteLine("3. Guadalajara");
					Console.WriteLine("4. Guanajuato");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 17:
					Console.WriteLine("The capital of Sweden is");
					Console.WriteLine("");
					Console.WriteLine("1. Gothenburg");
					Console.WriteLine("2. Helsingborg");
					Console.WriteLine("3. Stockholm");
					Console.WriteLine("4. Uppsala");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 18:
					Console.WriteLine("The capital of Norway is;!");
					Console.WriteLine("");
					Console.WriteLine("1. Oslo");
					Console.WriteLine("2. Bergen");
					Console.WriteLine("3. Alesund");
					Console.WriteLine("4. Stavanger");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 19:
					Console.WriteLine("The capital of Ecuador is");
					Console.WriteLine("");
					Console.WriteLine("1. Quito");
					Console.WriteLine("2. Cuenca");
					Console.WriteLine("3. Loja");
					Console.WriteLine("4. Guayaquil");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 20:
					Console.WriteLine("The capital of Japan is");
					Console.WriteLine("");
					Console.WriteLine("1. Osaka");
					Console.WriteLine("2. Hiroshima");
					Console.WriteLine("3. Yokohama");
					Console.WriteLine("4. Tokyo");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 21:
					Console.WriteLine("The capital of Madagascar is");
					Console.WriteLine("");
					Console.WriteLine("1. Antsirabe");
					Console.WriteLine("2. Antananarivo");
					Console.WriteLine("3. Toamasina");
					Console.WriteLine("4. Mahajanga");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 22:
					Console.WriteLine("The capital of Belgium is");
					Console.WriteLine("");
					Console.WriteLine("1. Antwerp");
					Console.WriteLine("2. Leuven");
					Console.WriteLine("3. Brussels");
					Console.WriteLine("4. Namur");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 23:
					Console.WriteLine("The capital of the UK is");
					Console.WriteLine("");
					Console.WriteLine("1. London");
					Console.WriteLine("2. Manchester ");
					Console.WriteLine("3. Bristol");
					Console.WriteLine("4. Liverpool");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 24:
					Console.WriteLine("The capital of Malaysia is");
					Console.WriteLine("");
					Console.WriteLine("1. Kuala Lumpur");
					Console.WriteLine("2. Ipoh");
					Console.WriteLine("3. Johor Bahru");
					Console.WriteLine("4. Malacca");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 25:
					Console.WriteLine("The capital of Pakistan is");
					Console.WriteLine("");
					Console.WriteLine("1. Lahore");
					Console.WriteLine("2. Karachi");
					Console.WriteLine("3. Faisalabad");
					Console.WriteLine("4. Islamabad");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 26:
					Console.WriteLine("The capital of Turkey is");
					Console.WriteLine("");
					Console.WriteLine("1. Istanbul");
					Console.WriteLine("2. Ankara");
					Console.WriteLine("3. Antalya");
					Console.WriteLine("4. Gaziantep");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 27:
					Console.WriteLine("The capital of Austria is");
					Console.WriteLine("");
					Console.WriteLine("1. Graz");
					Console.WriteLine("2. Linz");
					Console.WriteLine("3. Vienna");
					Console.WriteLine("4. Salzburg");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 28:
					Console.WriteLine("The capital of Thailand is");
					Console.WriteLine("");
					Console.WriteLine("1. Bangkok");
					Console.WriteLine("2. Phuket");
					Console.WriteLine("3. Chiang Mai");
					Console.WriteLine("4. Pattaya City");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 29:
					Console.WriteLine("The capital of Greece is");
					Console.WriteLine("");
					Console.WriteLine("1. Athens");
					Console.WriteLine("2. Thessaloniki");
					Console.WriteLine("3. Nafplion");
					Console.WriteLine("4. Sparti");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 30:
					Console.WriteLine("The capital of Poland is");
					Console.WriteLine("");
					Console.WriteLine("1. Wroclaw");
					Console.WriteLine("2. Gdynia");
					Console.WriteLine("3. Katowice");
					Console.WriteLine("4. Warsaw");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				default:
					break;
			}
			if (int.Parse(Console.ReadLine()) == correctAnswer)
			{
				AddPoint();
			}
		}
		static void PlayMiscellaneous()
		{
			int correctAnswer = 0;

			Console.WriteLine(Global.playerNames[Global.playerId] + " Your Topic is Miscellaneous");
			Console.WriteLine("\n");

			switch (GetRandomNumber())
			{
				case 1:
					Console.WriteLine("What is the name for the Jewish New Year?");
					Console.WriteLine("");
					Console.WriteLine("1. Hanukkah");
					Console.WriteLine("2. Rosh Hashanah");
					Console.WriteLine("3. Yom Kippur");
					Console.WriteLine("4. Kwanza");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 2:
					Console.WriteLine("How many blue stripes are there on the U.S. flag?");
					Console.WriteLine("");
					Console.WriteLine("1. 0");
					Console.WriteLine("2. 6");
					Console.WriteLine("3. 7");
					Console.WriteLine("4. 13");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 3:
					Console.WriteLine("Which one of these characters is not friends with Harry Potter?");
					Console.WriteLine("");
					Console.WriteLine("1. Draco Malfoy");
					Console.WriteLine("2. Ron Weasley");
					Console.WriteLine("3. Hermione Granger");
					Console.WriteLine("4. Neville Longbottom");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 4:
					Console.WriteLine("What is the color of Donald Duck’s bowtie?");
					Console.WriteLine("");
					Console.WriteLine("1. Red");
					Console.WriteLine("2. Yellow");
					Console.WriteLine("3. Blue");
					Console.WriteLine("4. White");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 5:
					Console.WriteLine("Which animal does not appear in the Chinese zodiac?");
					Console.WriteLine("");
					Console.WriteLine("1. Dragon");
					Console.WriteLine("2. Dog");
					Console.WriteLine("3. Rabbit");
					Console.WriteLine("4. Hummingbird");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 6:
					Console.WriteLine("Which country held the 2016 Summer Olympics?");
					Console.WriteLine("");
					Console.WriteLine("1. China");
					Console.WriteLine("2. Brazil");
					Console.WriteLine("3. Ireland");
					Console.WriteLine("4. Italy");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 7:
					Console.WriteLine("Which planet is the hottest?");
					Console.WriteLine("");
					Console.WriteLine("1. Mars");
					Console.WriteLine("2. Mercury");
					Console.WriteLine("3. Venus");
					Console.WriteLine("4. Saturn");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 8:
					Console.WriteLine("Who was the only U.S. President to resign?");
					Console.WriteLine("");
					Console.WriteLine("1. Richard Nixon");
					Console.WriteLine("2. Barack Obama");
					Console.WriteLine("3. Gerald Ford");
					Console.WriteLine("4. Herbert Hoover");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 9:
					Console.WriteLine("What does the “D” in “D-Day” stand for?");
					Console.WriteLine("");
					Console.WriteLine("1. The Day");
					Console.WriteLine("2. Dooms");
					Console.WriteLine("3. Dark");
					Console.WriteLine("4. Denmark");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 10:
					Console.WriteLine("In which city can you find the Liberty Bell?");
					Console.WriteLine("");
					Console.WriteLine("1. Boston");
					Console.WriteLine("2. New York City");
					Console.WriteLine("3. Chicago");
					Console.WriteLine("4. Philadelphia");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 11:
					Console.WriteLine("What is the rarest blood type?");
					Console.WriteLine("");
					Console.WriteLine("1. O");
					Console.WriteLine("2. AB-negative");
					Console.WriteLine("3. A");
					Console.WriteLine("4. B");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 12:
					Console.WriteLine("In The Wizard of Oz, the Tin Man wanted to see the Wizard about getting");
					Console.WriteLine("");
					Console.WriteLine("1. A brain");
					Console.WriteLine("2. A dog");
					Console.WriteLine("3. A heart");
					Console.WriteLine("4. An oil can");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 13:
					Console.WriteLine("Which U.S. state is known as the sunflower state?");
					Console.WriteLine("");
					Console.WriteLine("1. Kansas");
					Console.WriteLine("2. Florida");
					Console.WriteLine("3. Maryland");
					Console.WriteLine("4. Maine");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 14:
					Console.WriteLine("Which one of these characters isn’t a part of the Friends group?");
					Console.WriteLine("");
					Console.WriteLine("1. Gunther");
					Console.WriteLine("2. Rachel");
					Console.WriteLine("3. Joey");
					Console.WriteLine("4. Monica");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 15:
					Console.WriteLine("How many bones are there in the human body?");
					Console.WriteLine("");
					Console.WriteLine("1. 615");
					Console.WriteLine("2. 612");
					Console.WriteLine("3. 207");
					Console.WriteLine("4. 206");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 16:
					Console.WriteLine("Fe is the chemical symbol for");
					Console.WriteLine("");
					Console.WriteLine("1. Zinc");
					Console.WriteLine("2. Iron");
					Console.WriteLine("3. Hydrogen");
					Console.WriteLine("4. Fluorine");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 17:
					Console.WriteLine("What language is the most spoken worldwide?");
					Console.WriteLine("");
					Console.WriteLine("1. English");
					Console.WriteLine("2. Spanish");
					Console.WriteLine("3. Chinese");
					Console.WriteLine("4. Arabic");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 18:
					Console.WriteLine("What is the #1 cookie in the U.S.?");
					Console.WriteLine("");
					Console.WriteLine("1. Oreo");
					Console.WriteLine("2. Chips Ahoy!");
					Console.WriteLine("3. Milano");
					Console.WriteLine("4. Nutter Butter");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 19:
					Console.WriteLine("How many hearts does an octopus have?");
					Console.WriteLine("");
					Console.WriteLine("1. 1");
					Console.WriteLine("2. 2");
					Console.WriteLine("3. 3");
					Console.WriteLine("4. 4");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 20:
					Console.WriteLine("Which social media platform came out in 2003?");
					Console.WriteLine("");
					Console.WriteLine("1. Facebook");
					Console.WriteLine("2. Twitter");
					Console.WriteLine("3. Tumblr");
					Console.WriteLine("4. Myspace");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 21:
					Console.WriteLine("The Powerpuff Girls are 3 distinct colors. What are they?");
					Console.WriteLine("");
					Console.WriteLine("1. Red, yellow, green");
					Console.WriteLine("2. Blue, green, red");
					Console.WriteLine("3. Yellow, blue, green");
					Console.WriteLine("4. Green, purple, orange");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 22:
					Console.WriteLine("Who painted the Sistine Chapel ceiling?");
					Console.WriteLine("");
					Console.WriteLine("1. Picasso");
					Console.WriteLine("2. Da Vinci");
					Console.WriteLine("3. Michelangelo");
					Console.WriteLine("4. Van Gogh");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 23:
					Console.WriteLine("In which state did the Salem Witch Trials take place?");
					Console.WriteLine("");
					Console.WriteLine("1. Massachusetts");
					Console.WriteLine("2. Washington");
					Console.WriteLine("3. Virginia");
					Console.WriteLine("4. Pennsylvania");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 24:
					Console.WriteLine("Which ocean is the largest?");
					Console.WriteLine("");
					Console.WriteLine("1. Atlantic");
					Console.WriteLine("2. Pacific");
					Console.WriteLine("3. Indian");
					Console.WriteLine("4. Arctic");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 25:
					Console.WriteLine("Which country gifted the Statue of Liberty to the U.S.?");
					Console.WriteLine("");
					Console.WriteLine("1. China ");
					Console.WriteLine("2. Italy");
					Console.WriteLine("3. Spain");
					Console.WriteLine("4. France");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 4;
					break;

				case 26:
					Console.WriteLine("Who painted the Mona Lisa?");
					Console.WriteLine("");
					Console.WriteLine("1. Van Gogh");
					Console.WriteLine("2. Da Vinci");
					Console.WriteLine("3. Picasso");
					Console.WriteLine("4. Monet");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				case 27:
					Console.WriteLine("Which country consumes the most chocolate?");
					Console.WriteLine("");
					Console.WriteLine("1. Spain");
					Console.WriteLine("2. Germany");
					Console.WriteLine("3. Switzerland");
					Console.WriteLine("4. USA");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 3;
					break;

				case 28:
					Console.WriteLine("Which astrological sign is a crab?");
					Console.WriteLine("");
					Console.WriteLine("1. Cancer");
					Console.WriteLine("2. Aquarius");
					Console.WriteLine("3. Pisces");
					Console.WriteLine("4. Virgo");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 29:
					Console.WriteLine("What is the longest river in the world?");
					Console.WriteLine("");
					Console.WriteLine("1. Nile");
					Console.WriteLine("2. Amazon");
					Console.WriteLine("3. Congo");
					Console.WriteLine("4. Hudson");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 1;
					break;

				case 30:
					Console.WriteLine("How many days are in February during a leap year?");
					Console.WriteLine("");
					Console.WriteLine("1. 28");
					Console.WriteLine("2. 29");
					Console.WriteLine("3. 30");
					Console.WriteLine("4. 31");
					Console.WriteLine("");
					Console.WriteLine("Please select the correct answer![1-4]");
					correctAnswer = 2;
					break;

				default:
					break;
			}
			if (int.Parse(Console.ReadLine()) == correctAnswer)
			{
				AddPoint();
			}
		}
		static void exit()
		{
			string winnerName;
			
			SetBackground("initial");
			Console.WriteLine("\t\t\tThe Lilia Trivia Game!");
			Console.WriteLine("");
			Console.WriteLine("{0} and {1}, thanks for playing my Trivia Game. ", Global.playerNames[0], Global.playerNames[1]);
			Console.WriteLine("");
			if (Global.playerScores[0] > Global.playerScores[1])
				winnerName = Global.playerNames[0];
			else if (Global.playerScores[0] < Global.playerScores[1])
				winnerName = Global.playerNames[1];
			else
				winnerName = "It is a tie";
			Console.WriteLine("{0}, congratulations!!!", winnerName);
			Console.WriteLine("");
			Console.WriteLine("\t\t\tCome back again!");
			Console.ReadLine();
			Environment.Exit(0);
		}
	}
}

