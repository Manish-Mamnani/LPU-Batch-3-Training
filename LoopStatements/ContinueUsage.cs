using System;

namespace LoopStatements;

public class ContinueUsage
{
    public void ContinueMain()
    {
        for(int i = 1; i <= 50; i++)
        {
            if(i % 3 == 0)
            {
                continue; 
            }
            System.Console.WriteLine(i);
        }

    }
}   
