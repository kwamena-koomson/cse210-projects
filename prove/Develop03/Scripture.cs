using System;
using System.Collections.Generic;

public class Scripture
{
    private string _scriptureText;
    private Reference _scripReference;
    private List<Word> _wordsList;
    private List<int> _indexesList;
    private bool _isCompletelyHidden;
    private static Random _rnd = new Random();

    public Scripture(string sentence, Reference reference) 
    {
        _scriptureText = sentence;
        _scripReference = reference;
        MakeList();
    }

    public string MakeScripture()
    {
        string sentence = _scripReference.MakeReference();
        foreach (var item in _wordsList)
        {
            sentence += $" {item.DisplayText()}";
        }
        return sentence;
    }

    private void MakeList()
    {   
        _wordsList = new();
        _indexesList = new();
        List<string> words = _scriptureText.Split(" ").ToList();
        int index = 0;
        foreach (var item in words)
        {
            Word tempWord = new(item);
            _wordsList.Add(tempWord);
            _indexesList.Add(index);
            index++;
        }
    }

    public void HideWords()
    {
        for (int i = 0; i < 3; i++)
        {
            int index = _rnd.Next(_indexesList.Count);
            _wordsList[_indexesList[index]].Hide();
            _indexesList.RemoveAt(index);
        }
        
        if (_indexesList.Count == 0)
        {
            _isCompletelyHidden = true;
        }
    }

    public bool IsCompletelyHidden
    {
        get { return _isCompletelyHidden; }
        set { _isCompletelyHidden = value; }
    }    
}
