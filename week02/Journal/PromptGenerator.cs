using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        string[] lines = File.ReadAllLines("prompts.txt");
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }

        Random random = new Random();                
        int index = random.Next(_prompts.Count);    
        return _prompts[index]; 
    }
}