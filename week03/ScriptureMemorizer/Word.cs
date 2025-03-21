using System;

class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Words are visible by default when created
    }

    // Method to hide the word if it is not already hidden
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show the word if it is hidden
    public void Show()
    {
        _isHidden = false;
    }

    // Method to check if the word is hidden or not
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to get the display text of the word (hidden if necessary) And return the text with underscores if the word is hidden
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}