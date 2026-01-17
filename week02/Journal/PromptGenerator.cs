using System;

public class PromptGenerator()
{
    public List<string> _prompts = new List<string>();
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        
        return _prompts[random.Next(0, _prompts.Count-1)];  
    }
}