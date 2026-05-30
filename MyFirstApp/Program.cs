int playerHP = 100;
int playerFuel = 0;

Console.WriteLine("---- 비행기 내구도와 연료 연산---");

// 1. 논리연산자 활용하기

if (playerHP == 0 || playerFuel == 0)
{
    Console.WriteLine("비행기 추락!");
}
else
{
    if (playerHP > 50 && playerFuel >50)
    {
        Console.WriteLine("상태와 연료량 양호!");
    }
    else
    {
        Console.WriteLine("비행시 주의필요!");
    }
}