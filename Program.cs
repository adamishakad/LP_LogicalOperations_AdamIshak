// Adam Ishak
using System.Net.NetworkInformation;
using System.Numerics;

namespace LP_LogicalOperations_AdamIshak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Checking if a Number is Even or Positive (Easier)
            int num = 6;
            // Requires Comparison Operator: Checking if num is even
            bool isEven = num % 2 == 0;
            // Requires Comparison Operator: Checking if num is positive
            bool isPositive = num > 0;
            // Requires Logical Operator: Combining isEven and isPositive
            bool isEvenAndPositive = isEven && isPositive;
            Console.WriteLine($"Is 'num' even and positive? {isEvenAndPositive}");

           // Question 2: Checking User Role(Easier)

            string input = "moderator";
            // Requires Comparison Operator: Checking if input is "admin"
            bool isAdmin = (input == "admin");
            // Requires Comparison Operator: Checking if input is "moderator"
            bool isModerator = (input == "moderator");
            // Requires Logical Operator: Combining isAdmin and isModerator
            bool isAuthorized = isAdmin && isModerator;
            Console.WriteLine($"Is the user authorized? {isAuthorized}");

            // Question 3: Checking Age Eligibility(Easy)

            int age = 21;

            // Requires Comparison Operator: Checking if age is greater than or equal to 18
            bool isAgeAtLeast18 = (age >= 18);

            // Requires Comparison Operator: Checking if age is less than or equal to 100
            bool isAgeAtMost100 = (age <= 100);

            // Requires Logical Operator: Combining isAgeAtLeast18 and isAgeAtMost100 using logical AND
            bool isEligibleToVote = isAgeAtLeast18 && isAgeAtMost100;
            Console.WriteLine($"Is the person eligible to vote? {isEligibleToVote}");

            // Question 4: Checking Online Status and Login using Logical Operator (Medium)

            bool isOnline = true;
            bool isLoggedIn = true;
            // Requires Logical Operator: Combining isOnline and isLoggedIn
            bool canAccess = isOnline && isLoggedIn;
            Console.WriteLine($"Can the user access? {canAccess}");

            // Question 5: Checking Player's High Score using Logical Operator (Medium)

            int playerScore = 1200;
            // Requires Comparison Operator: Checking if playerScore is greater than or equal to 1000
            bool isHighScore = (playerScore >= 1000);
            // Requires Comparison Operator: Checking if playerScore is less than or equal to 5000
            bool isLowScore = (playerScore <= 5000);
            // Requires Logical Operator: Combining isHighScore and isLowScore
            bool isHighOrLowScore = isHighScore && isLowScore;
            Console.WriteLine($"Is the player's score a high or low score? {isHighOrLowScore}");

            // Question 6: Subscription Access Control using Logical Operator (Medium)
            bool hasPaid = false;
            bool isTrialExpired = false;
            // Requires Logical Operator: Combining hasPaid and isTrialExpired
            bool canAccessWithPayment = hasPaid && isTrialExpired;
            // Requires Logical Operator: Negating isTrialExpired
            bool canAccessWithTrial = !isTrialExpired;
            // Requires Logical Operator: Combining canAccessWithPayment and canAccessWithTrial
            bool canAccessContent = canAccessWithPayment || canAccessWithTrial;
            Console.WriteLine($"Can the user access content? {canAccessContent}");


            // Question 7: Complex Access Control System with Multiple Conditions

            bool hasAccessCard = true;
            bool hasBiometricScan = false;
            int securityClearanceLevel = 4; // Replace with an actual security clearance level.

            // Requires Comparison Operator: Checking if the user has a valid access card
            bool canEnter = hasAccessCard;

            // Requires Logical Operator: Combining canEnter and checking if the user has a biometric scan
            bool canProceedToLevel2 = canEnter && hasBiometricScan;

            // Requires Logical Operator: Combining canProceedToLevel2 and checking if the security clearance level is 5 or higher
            bool canProceedToLevel3 = canProceedToLevel2 && securityClearanceLevel >= 5;

            Console.WriteLine("Level 1 - Can Enter: " + canEnter);
            Console.WriteLine("Level 2 - Can Proceed (Biometric Scan): " + canProceedToLevel2);
            Console.WriteLine("Level 3 - Can Proceed (Security Clearance): " + canProceedToLevel3);












        }
    }
}
