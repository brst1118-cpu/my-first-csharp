using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("--- 10일차: 키보드 또는 모바일 터치 입력 시스템 시뮬레이션");

        float inputX = 0.0f;
        sting currentPlatform = "PC";

        if (currentPlatform == "PC")
        {
            float virtuaKeyboardInput = 1.0f;
            inputX = virtuaKeyboardInput;
            Console.WriteLine($"[{currentPlatform}] 키보드 입력감지: {virtuaKeyboardInput}");            
        }
        else if (currentPlatform == "Mobile")
        {
            float virtuaKeyborardInput = 1.0f;
            inputX = virtuaKeyboardInput;
            Console.Writeline($"[{currentPlatform}] 키보드 입력감지: {virtuaKeyboardInput}")
        }
        float moveSpeed = 5.5f;
        float finalMovement = inputX * moveSpeed;
    }
}

    
