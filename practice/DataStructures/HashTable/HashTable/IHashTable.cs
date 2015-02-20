﻿namespace Epam.NetMentoring.HashTable
{
    //IT: must have been public!
    public interface IHashTable
    {
        bool Contains(WordEntity key);
        void Add(WordEntity key, WordDefinition value);
        WordDefinition Get(WordEntity key);
        WordDefinition this[WordEntity key] { get; set; }
    }
}
