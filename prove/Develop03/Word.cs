using System;

public class Word 
{
    private string _word;
    private bool _isHidden;
    private static Random rnd = new Random();

    public Word(string word) 
    {
        _word = word;
        _isHidden = false;
    }

    public void Hide()
    {   
        _isHidden = true;
    }

    public void UnHide()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string DisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _word.Length);
        } 
        else
        {   
            return _word;
        }
    }
}
