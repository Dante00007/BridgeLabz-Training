/*
  Create a program to display a calendar for a given month and year.
   The program should take the month and year as input from the user and display the calendar for that month. 
   E.g. for 07 2005 user input, the program should display the calendar as shown below
   Hint => 
a.               Write a Method to get the name of the month. For this define a month Array to store the names of the months
b.               Write a Method to get the number of days in the month. For this define a days Array to store the number of days in each month. For Feb month, check for Leap Year to get the number of days. Also, define a Leap Year Method. 
c.                Write a method to get the first day of the month using the Gregorian calendar algorithm
y0 = y − (14 − m) / 12
x = y0 + y0/4 − y0/100 + y0/400
m0 = m + 12 × ((14 − m) / 12) − 2
d0 = (d + x + 31m0 / 12) mod 7
d.  Displaying the Calendar requires 2 for loops. 
e.  The first for loop up to the first day to get the proper indentation. As in the example above 3 spaces from Sun to Thu as to be set as July 1st starts on Fri
f.  The Second for loop Displays the days of the month starting from 1 to the number of days. Add proper indentation for single-digit days using %3d to display the integer right-justified in a field of width 3. Please note to move to the next line after Sat
*/

class Calender{
    public static string[] month = {"January", "February", "March", "April", 
                                    "May", "June", "July", "August",
                                    "September", "October", "November", "December"};

    public static int[] days = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
    
    public static string GetMonthName(int monthNumber){
        return month[monthNumber - 1];
    }
    public static int GetDaysInMonth(int monthNumber, int year){
        if(monthNumber == 2 && LeapYear.CheckYear(year))
            return 29;
        return days[monthNumber - 1];
    }
    static void Main(){

    }
}