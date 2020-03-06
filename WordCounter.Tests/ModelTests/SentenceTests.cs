using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
	[TestClass]
	public class SentenceTests
	{
		[TestMethod]
		public void SentenceConstructor_CreatesInstanceOfSentence_Word()
		{
			string myWord = "word";
			string mySentence = "These apples are the best apples in all the land.";
			Sentence sentence = new Sentence(myWord, mySentence);

			string actual = sentence.InputWord;

			Assert.AreEqual(myWord, actual);
		}
		[TestMethod]
		public void SentenceConstructor_CreatesInstanceOfSentence_Sentence()
		{
			string myWord = "word";
			string mySentence = "These apples are the best apples in all the land.";
			Sentence sentence = new Sentence(myWord, mySentence);

			string actual = sentence.InputSentence;

			Assert.AreEqual(mySentence, actual);
		}

		[TestMethod]
		public void SentenceToInputArray_ConvertsUserSentenceToArrayOfStrings_Array()
		{
			//Arrange
			string mySentence = "These apples are the best apples in all the land.";
			Sentence inputSentence = new Sentence("the", mySentence);
			//Act

		string [] sentenceArray = mySentence.Split(' ');
		string [] mySentenceArray = inputSentence.SentenceToWordArray();
			
			//Assert
			CollectionAssert.AreEqual(mySentenceArray, sentenceArray);
		}
	}
}