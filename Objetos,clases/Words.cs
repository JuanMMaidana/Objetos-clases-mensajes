using System;

public class Word
{
    private string text;
    
    public Word(string text)
    {
        this.Text = text
    }

    public string Text
    {
        get
        {
            return this.text;
        }

        set 
        {
            this.text = value.Trim();
        }
    }
}