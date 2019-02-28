using System;


namespace CSharpFundamentals
{
    public class SpeedCamera
    {
        public void CalculateSpeedLimit()
        {
            Console.WriteLine("Please enter the current speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now enter the speed of your car: ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            var demeritPoints = 0;

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok!");
            }
            else if (carSpeed > speedLimit + 5)

            {
                demeritPoints = 1;
                Console.WriteLine($"You will now suffer {demeritPoints} demerit points :(");
            }
            else if (demeritPoints > 12)
            {
                Console.WriteLine("We have to suspend your license");
            }
        }
    }
}