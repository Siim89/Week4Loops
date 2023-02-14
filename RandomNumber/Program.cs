

Random rnd = new Random();

int myRandomnum;

int randomSum = 0;   

for(int i = 0;i < 6; i++) 
{
    int myRandomNum = rnd.Next(0, 11);
    randomSum= randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"random sum total: {randomSum}");