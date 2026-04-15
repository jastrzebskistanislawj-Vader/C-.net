using System;

// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTime(times);

// Console.WriteLine();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

// Console.WriteLine("New Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTime(times);

// Console.WriteLine();








// void DisplayTime(int[] times)
// {
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
// }


string[] ipAddress = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
foreach (string ip in ipAddress)
{
    string[] octets = ip.Split('.');
    System.Console.WriteLine($"The IP address {ip} is {(CheckifIp(octets) ? "correct" : "incorrect")}");
}

bool CheckifIp(string[] octets)
{
    if (octets.Length != 4)
    {
        return false;
    }

    foreach (string octet in octets)
    {
        int octetValue;
        if (!int.TryParse(octet, out octetValue) || octetValue < 0 || octetValue > 255 || octet.StartsWith("0") && octet.Length > 1)
        {
            return false;
        }
    }

    return true;
}