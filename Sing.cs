namespace BeerAssignment
{
    public class BeerSong
    {
        public void Sing()
        {
            // Loop through the bottles of beer
            for (int bottles = 99; bottles >= 1; bottles--)
            {
                // Determine whether to use "bottle" or "bottles" based on the current count
                string bottleText = bottles == 1 ? "bottle" : "bottles";
                string nextBottleText = (bottles - 1) == 1 ? "bottle" : "bottles";

                // Print the current verse
                Console.WriteLine($"{bottles} {bottleText} of beer on the wall, {bottles} {bottleText} of beer. Take one down and pass it around\n");

            }
        }
    }
}
