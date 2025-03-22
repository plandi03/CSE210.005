using System;
using System.Collections.Generic;

class Scripture

{
    private Reference _reference; // Reference object to store the book, chapter, and verse
    private List<Word> _words;      // List of Word objects to store the words in the scripture

    // Constructor for the Scripture class
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects to then hide words
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Method to hide random words in the scripture
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        // Ensure we don't attempt to hide more words than are visible
        int visibleWords = _words.Count(word => !word.IsHidden());
        numberToHide = Math.Min(numberToHide, visibleWords);

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    // Method to get the display text of the scripture with hidden words
    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText() + ": ";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return scriptureText.Trim();
    }

    // Method to check if the scripture is completely hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}