using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Models;

public class Hand
{
    private readonly ICollection<Card> cards;

    public Hand()
    {
        cards = new List<Card>();
    }
    
    public Card HighCard
    {
        get
        {
            if (!cards.Any())
            {
                throw new InvalidOperationException();
            }

            var orderedCards = cards.OrderByDescending(card => card.Value).ToList();
            
            return orderedCards.First();
        }
    }
    
    public IEnumerable<Card> Cards => cards;

    public HandRanking Rank { get; private set; } = HandRanking.Unknown;

    public void Add(Card card)
    {
        if (cards.Count == 5)
        {
            throw new InvalidOperationException("Cannot add more than 5 cards to a hand.");
        }

        cards.Add(card);

        if (cards.Count == 5)
        {
            Rank = HandCategorizerChain.GetRank(this);
        }
    }
    
    public override string ToString()
    {
        var builder = new StringBuilder();
        foreach (var card in cards)
        {
            builder.AppendFormat($"{card} ");
        }

        return builder.ToString();
    }
}