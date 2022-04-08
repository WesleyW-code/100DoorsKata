using System;

namespace HundredDoorsKata;

public class Hundred
{
    public static void Main()
    {
        
        Console.WriteLine(DoorManipulator("@@@@@"));

    }
    public static string DoorManipulator(string Doors)
    {
        char[] doors = Doors.ToCharArray();
        // This for loop is for each pass.
        for (int i = 1; i < Doors.Length+1; i++)
        {
            // This for loop is for each door.
            for (int j = 0; j < Doors.Length; j++)
            {
                // This selects the doors that need to be changed on the current pass.
                if ((j+1) % i == 0)
                {
                    // Checking for the three possible cases (open or holding or closed).
                    // Switches are awesome!
                    switch (doors[j])
                    {
                        case '@':
                            doors[j] = 'H';
                            break;
                        case '#':
                            doors[j] = '@';
                            break;
                        case 'H':
                            doors[j] = '#';
                            break;

                    }

                }
            }
    
        }
        // Returns the updates string.
        string updatedDoors = new(doors);
        return updatedDoors;
    }
}