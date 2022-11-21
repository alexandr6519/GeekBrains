int countOfRunsOfDog = 0;
double distance = 1000;
double firstFriendSpeed = 4;
double secondFriendSpeed = 5;
double dogSpeed = 25;
bool directionToSecondFriend = true;


while (distance > 10) 
{
    double time;
    if (directionToSecondFriend) {
        time = distance / (dogSpeed + secondFriendSpeed);
    } else {
        time = distance / (dogSpeed + firstFriendSpeed);
    }
    directionToSecondFriend = !directionToSecondFriend;
    distance -= (firstFriendSpeed + secondFriendSpeed) * time;
    countOfRunsOfDog ++;
}

Console.WriteLine("Our dog was run between friends " + countOfRunsOfDog + " times!");
