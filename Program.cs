namespace ConsoleApp1
{
    internal class Program
      
    {


        static int pibonachi(int idxNum)
        {
            int leftNum = 1;
            int rightNum = 1;
            int resultNum = 0;
            if (idxNum == 1)
            {
                return 1;
            }
            else if (idxNum == 2)
            {
                return 1;
            }else if(idxNum == 3)
            {
                return 2;
            }
            else
            {
                return pibonachi(idxNum-1)+pibonachi(idxNum-2);

            }
        }
        static int decoder(int num)//56 -> 6
        {
            if (num <= 0)
            {
                return 0;
                
            }
            else
            {
                string numLength = num.ToString();
                int storeNum = 0;
                int sum = 0;
                int tenMult = 1;
                int idx = numLength.Length;//2 =>1 
                for(int i = 0; i < idx-1; i++)
                {
                    tenMult = tenMult * 10;
                }
               // Console.WriteLine(idx);//2
                sum = num / tenMult;//2 sum=>5 =>
                storeNum = decoder(num - (sum * tenMult));//decoder(6)
                sum = sum + storeNum;//5+decoder(6)

                return sum;//5+decoder(6)
            }
        }
        struct Point //구조체는 값타입 참조형 아님
        {
            public int x;
            public int y;
        }
        enum enumTest
        {
            a,b,c
        }

        enum Stages
        {
            town, huntingPlace, store
        }

        struct XYCoord
        {
            public short x;
            public short y;
        }
        /*struct Weapon
        {
            public int Dmg;
            public float Critical;
            public string Name;
        }*/
        enum carMaker
        {
            Honda, Audi, BMW, Kia
        }
        struct Car
        {
            public float maxSpeed;
            public int carNumber;
            public enum carMaker;

        }enum itemType
        {
            방어구, 무기, 소모품
        }
        struct Item
        {
            public string itemName;
            public int itemPrice;
            public itemType itemT; //itemType는 열거형 데이터 타입 변수는 itemT로 별도 지정 필요!

        }
        struct Weapon
        {
            public string name;
        }
        struct Soldier
        {
            public Weapon[] WeaponList;
            public int WeaponIndex;
        }
        static int maxNumInt(int n1,int n2,int n3, int n4)
        {
            int[] numList = new int[4];
            int maxNum=n1;
            numList[0] = n1;
            numList[1] = n2;
            numList[2] = n3;
            numList[3] = n4;
            for (int i = 0; i < 4; i++) {
                if (maxNum < numList[i])
                {
                    maxNum=numList[i];
                }
            }
            return maxNum;
        }
        static void ShowInventory(Item[] arr)
        {
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine($"아이템의 이름은 { arr[i].itemName}");
                Console.WriteLine($"가격은 {arr[i].itemPrice}");
                Console.WriteLine($"타입은 {arr[i].itemT}");
            }
        }
        static void ChangeWeapon(Soldier soldier, ref int weaponSelecter)
        {
            bool sw = true;
            for (int i = 0; i < soldier.WeaponList.Length; i++)
            {
                Console.WriteLine(soldier.WeaponList[i].name);
            }
            Console.WriteLine("어떤 무기로 변경하겠습니까?");
            while(sw)
            {
                int oldState = weaponSelecter;
                int.TryParse(Console.ReadLine(), out weaponSelecter);
                
                
                if (oldState == weaponSelecter)
                {
                    Console.WriteLine(" 현재 들고 있는 무기와 동일합니다. 다시 입력해 주세요");
                }
                else
                {
                    switch (weaponSelecter)
                    {
                        case 1:
                            Console.WriteLine($"{soldier.WeaponList[0].name}로 변경되었습니다.");
                            sw = false;
                            break;
                        case 2:
                            Console.WriteLine($"{soldier.WeaponList[1].name}로 변경되었습니다.");
                            sw = false;
                            break;
                        case 3:
                            Console.WriteLine($"{soldier.WeaponList[2].name}로 변경되었습니다.");
                            sw = false;
                            break;
                        default:
                            Console.WriteLine("옳지 못한 입력입니다. 다시 1~3의 정수를 입력하십시오");
                            break;






                    }
                }
            }


        }
        static float maxFloatSum(float a,float b,float c, float d, float e)
        {
            float leftNum = a;
            float maxNum2 = a;
            float[] numList= new float[5];
            numList[0] = a;
            numList[1] = b;
            numList[2] = c;
            numList[3] = d;
            numList[4] = e;
            int flag = 0;
            while (true)
            {
                flag = 4;
                for (int i = 0; i < 4; i++)
                {
                    if (numList[i + 1] < numList[i])
                    {
                        leftNum = numList[i];
                        numList[i] = numList[i + 1];
                        numList[i + 1] = leftNum;
                        flag -= 1;
                    }
                    
                }


                if (flag == 4)
                {
                    break;
                }



            }
            return numList[4] + numList[3];

        }
        static bool hundread(int a, int b) {
            if (a < b)
            {
                if (b - a < 100)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }else
            {
                if (a - b < 100)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        
        
        }

        static void Main(string[] args)
        {
            int inputNum;
            
            string name = "@@@@@@@@@@@@@@@@@%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#**+++%@@@@@@\r\n@@@@@@@@@@@@@@@%*###*+*#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#*###***+*@@@@@@\r\n@@@@@@@@@@@@@@@#%%%#*##*++#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#####****##*#@@@@@\r\n@@@@@@@@@@@@@@@%%%%##*****+=+%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%####****#**##*#@@@@@\r\n@@@@@@@@@@@@@@@%%%%%##*****#*==#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%###*********#*%@@@@@\r\n@@@@@@@@@@@@@@@%%@@%%#####***#*+=+%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#%%%##**#**++***##*%@@@@@\r\n@@@@@@@@@@@@@@@%%@@@%%%#*****++***-=#%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%##%%%#####***++****##*%@@@@@\r\n@@@@@@@@@@@@@@@@%@@@@%%%###**#**#****=-+#%%%%##%%#*=-----========+++*+*##%%%#**#****+++**###*#@@@@@@\r\n@@@@@@@@@@@@@@@@%%@@@@@%%%####%###%%%**=-::::::...:::::::::-----===++++*%######****+++*#####*%@@@@@@\r\n@@@@@@@@@@@@@@@@@%@@@%@@%##%@%%%%@#%%#**+=====--:-:-:--=---==-=+=+==++++*#######******###%%##@@@@@@@\r\n@@@@@@@@@@@@@@@@@@%@@@@@@%@%@@@@@%##%*#*###*+====+==-=+=--=++===+#+++++++*********###**###*#@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@%@@@@@@@@@@@@@@%####*##**++++====+=+--::--=====*+++=+=+++**+*##***+**#++@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@%%@@@@@@@@%#%#%%####***+===--====-=--::--=+==+=+++==+++++*****##*==+*@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@%%@@@@@@@@%%%%@%%%%##****+=++---===----------====+=++++++++*#####+++=%@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@%%@@@@@@@@%%%%%%%%##***##+--+=::+++----:-============+==+++*#%##*#*=+@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@%%@@@@@@%%%@%%####****##+==+=--+++----::-============++++*#%%%%#*==%@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@%%@@@@@%%%#######***###++=+=-==*++++=--:=====+++=====++**+#%%#*=+%@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@%%@@%@@%%#%##%%####%%##**+===++*++*+==--===++*++==--=++++**#*-=#@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@%%%%%%%%#%%%%%%%%%%%%%%%%#**++*++++++====+**##*+==---===++=---+@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@%#%%%%%%%%%@@%%%@@@%%%%%%%*#++++======+=+#%@%%####+=---=-=--::=%@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@####%%%%%%@@%%%@@@%@@%#%#%%##++==------+###%@*-:-**===---:::::=%@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@%######%%%%@%#%%@@@%%%%%###%%**+---::::==+#*%@#--=**====--:::.:=@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@%#####%%%#%@##%@@@%%%@%###%##+==:::::-*==*###+=+#%+---=-::....=%@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@##*####%%#%@%%%%@@@@@%###%##*---:.::=+*==+**#%%#=-===--:....-#@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@%#*####%%%%%%%@@@%%%@@%##%#*+--::..:--=---+*++=======-::....+%@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@#*######%%%%%%%%%%%%%%#%#*==-::::.:-----===+++++==-::::...-#@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@%#*#####%%%%%%%%%%%%%%###*+=-::...::---=++======--::::...:*@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@#*#######%%%%%%%%%%%####*==--::..::::--=======--:::::...=#%@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@%#*###%####%%%%####%#####+===--::::::::----===----:::..:+#@%%@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@%######%%###%#####%%%@@@@%%#*+=-::::::::::--=====-:..:+%@@@@@@%@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#######%%###%%%%%%%@@@@@@%%#+-:::---:::::------::::-*%%@@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@##########%%%%%%%%%%%%@@@#*=-------------=====---::-+*%@@@%@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#############%%%######%@#+===--===+=--:====---:---:=*@@#%@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%@%####%##########%#####%%#+=======---:--==-------::::=#%@@%@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%###%%%%%%%######%%%%@@%%%%%##*+----====--==-------:-+%@@@%%@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%######%%%%%%######%%%###*#***+=---=+=+====----------:-+@@@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%####%%%%%%%%%%%%########++==---+****++=====-----------=#%@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%######%%%%%%%%%@%%%%##***+===*##%%##**++====------------+%@@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#######%%%%%%%%%%%@@%%############***+=====-----------:-=#%@@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#######%%#%%%%%%%%%%%%####*###*#*+++++====---------------*%%%@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%##########%%%%%%%##%####****#******+=======--------------+%%%%@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%###%###%%%%%%%%####*##***#**#***++**+=--=-=====----------=#@@%%@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@@####%##%#%%%%%%%##*******#*++##*++++++++===---------------=#%@@%%@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@%###%#%%%#%%%%%%######+###**++*#*++++====+====---==---=----=*%@@@%@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@%###%#%%%%#%%%%%#######%%##***+*#*++++========---===-==-----*%@@@@@@@@@@\r\n@@@@@@@@@@@@@@@@@@@@@@@@@@@@%#####%%%%%%%%%%%%%%%%%%%#%##***#**++++======---------=-----+*%@@@@@@@@@";
            Console.WriteLine(name);

            Console.WriteLine("출력할 다이아몬드를 홀수로 입력");
            while (true)
            {
                int.TryParse(Console.ReadLine(), out inputNum);
                if (inputNum == 1)
                {
                    Console.WriteLine("1이 아닌 값을 입력하시오");
                }
                else if (inputNum % 2 == 0)
                {
                    Console.WriteLine("홀수를 입력하시오");
                }
                else
                {
                    break;
                }

            }







            for(int i = 0; i < inputNum/2; i++)
            {
                for(int j=inputNum/2-i;j> 0; j--)
                {
                    
                    Console.Write(" ");
                }
                for(int j=0;j< inputNum-2*((inputNum / 2) - i); j++)
                {
                    Console.Write("*");
                }
                for (int j = inputNum / 2 - i; j > 0; j--)
                {

                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            for(int m=0; m < inputNum; m++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for(int i = 0; i < inputNum/2; i++)
            {
                for (int j = 0; j <= i; j++)
                {

                    Console.Write(" ");
                }
                for (int j = 0; j < inputNum - 2 * (i+1); j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j <= i; j++)
                {

                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            /*
            string name2;
            char[] chararray = name.ToCharArray(); // stringd을 char배열로 변경하는 기능
            chararray[0]= 'b';
            char[] chararray2;
            name = new string(chararray);//string인 name에 다시 담는 과정
            ConsoleKeyInfo pressedkey = Console.ReadKey();//입력받은 키를 저장하는 과정
            if(pressedkey.Key == ConsoleKey.A)//저장된 키가 A인지 확인하는 과정
            {
                Console.WriteLine("a");
            }
            Console.SetCursorPosition(1,2);//콘솔의 커서 위치를 1,2로 변경 변수 대입 가능
            int a = 123;
            int b = 153;
            name=a.ToString();
            chararray = name.ToCharArray();
            name = b.ToString();
            chararray2 = name.ToCharArray();
            for(int i = 0; i < chararray.Length; i++)
            {
                if(chararray[i] == chararray2[i])
                {
                    Console.WriteLine("same");
                }
            }*/
            /*
            int weaponSelecter = 1;
            Soldier nowSoldier;
            nowSoldier.WeaponList = new Weapon[3];
            nowSoldier.WeaponList[0].name = "sword";
            nowSoldier.WeaponList[1].name = "gun";
            nowSoldier.WeaponList[2].name = "magic";
            nowSoldier.WeaponIndex = 0;

            ChangeWeapon(nowSoldier, ref weaponSelecter);
            ChangeWeapon(nowSoldier, ref weaponSelecter);
            ChangeWeapon(nowSoldier, ref weaponSelecter);
            */

            int num1,num2,num3,num4;
            float fl1, fl2, fl3, fl4, fl5;
            /*
            Console.WriteLine("4개의 정수를 입력하시오");

            int.TryParse(Console.ReadLine(), out num1);
            int.TryParse(Console.ReadLine(), out num2);
            int.TryParse(Console.ReadLine(), out num3);
            int.TryParse(Console.ReadLine(), out num4);

            Console.WriteLine(maxNumInt(num1,num2,num3,num4));
            */
            /*
            Console.WriteLine("5개의 실수를 입력하시오");
            float.TryParse(Console.ReadLine(), out fl1);
            float.TryParse(Console.ReadLine(), out fl2);
            float.TryParse(Console.ReadLine(), out fl3);
            float.TryParse(Console.ReadLine(), out fl4);
            float.TryParse(Console.ReadLine(), out fl5);
            Console.WriteLine(maxFloatSum(fl1, fl2, fl3, fl4,fl5));
            */

            /*
            Console.WriteLine("2개의 정수를 입력하시오");
            int.TryParse(Console.ReadLine(), out num1);
            int.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine(hundread(num1,num2));
            num1 = 10 ^ num2;
            */
            /*
            Console.WriteLine("1개의 정수를 입력하시오");
            int.TryParse(Console.ReadLine(), out num3);
            
            //Console.WriteLine(decoder(num3));
            Console.WriteLine(pibonachi(num3));
            */
            /*
            Weapon Katana;
            Weapon Sword;
            Katana.Dmg = 130;
            Katana.Critical = 50.0f;
            Katana.Name = "카타나";
            Sword.Dmg = 170;
            Sword.Critical = 30.0f;
            Sword.Name = "양손검";
            */

            /*

            Item[] inventory = new Item[3];
            inventory[2].itemName = "악몽의 꽃 견갑";
            inventory[2].itemPrice = 500;
            inventory[2].itemT = itemType.방어구;
            ShowInventory(inventory);
            */

            /*
            Point myPoint;
            myPoint.x = 1;
            myPoint.y = 2;
            enumTest eTest;
            eTest = enumTest.a;
            for(int i= (int)eTest; i <= (int)enumTest.c; i++)
            {   
                Console.WriteLine(i);
                Console.WriteLine($"{(enumTest)i}");
            }




            Stages stages;
            stages = Stages.town;
            Console.WriteLine("이동 할 장소를 설정해주세요");
            Console.WriteLine("마을");
            Console.WriteLine("사냥터");
            Console.WriteLine("상점");
            int toDetermine;
            
            Stages.TryParse(Console.ReadLine(), out stages);
            Console.Clear(); //화면을 지워줍니다
            switch (stages)
            {
                case Stages.town:
                    //Console.WriteLine(toDetermine);
                    Console.WriteLine("마을로 이동합니다");
                    break;
                case Stages.huntingPlace:
                    //Console.WriteLine(toDetermine);
                    Console.WriteLine("사냥터로 이동합니다");
                    break;
                case Stages.store:
                    //Console.WriteLine(toDetermine);
                    Console.WriteLine("상점으로 이동합니다");
                    break;
                default:
                    //Console.WriteLine(toDetermine);
                    Console.WriteLine("1,2,3 어느것도 아니에요");
                    break;
            }

            */
            /*
            int state = 0;
            bool shut = true;
            while (shut)
            {
                int oldState = state;
                int.TryParse(Console.ReadLine(), out state);
                if (oldState == state)
                {
                    switch (state) {
                        case 1:
                            Console.WriteLine("이미 idle 상태 입니다.");
                            break;
                        case 2:
                            Console.WriteLine("이미 run 상태 입니다.");
                            break;
                        case 3:
                            Console.WriteLine("이미 walk 상태 입니다.");
                            break;
                        default:
                            Console.WriteLine("옳지 못한 입력입니다. 다시 입력하십시오");
                            break;
                    }
                }
                else
                {
                    switch (state)
                    {
                        case 1:
                            Console.WriteLine("idle 상태로 변경되었습니다.");
                            break;
                        case 2:
                            Console.WriteLine("run 상태로 변경되었습니다.");
                            break;
                        case 3:
                            Console.WriteLine("walk 상태로 변경되었습니다.");
                            break;
                        case 9:
                            Console.WriteLine("사망하였습니다.");
                            shut = false;
                            break;
                        default:
                            Console.WriteLine("옳지 못한 입력입니다. 다시 입력하십시오");
                            break;






                    }
                }



            }*/









        }
    }
}
