﻿
double netPriceBook = 30;
double netPriceDVD = 50;
double netPriceGame = 100;

int noOfBooksInOrder = 1;
int noOfDVDsInOrder = 0;
int noOfGamesInOrder = 0;

double totalPrice = (((noOfBooksInOrder * netPriceBook + noOfDVDsInOrder * netPriceDVD + noOfGamesInOrder * netPriceGame) * 1.1)+49)*1.02; // This variable should contain the total price for the order


Console.WriteLine($"You ordered {noOfBooksInOrder} books, " +
                  $"{noOfDVDsInOrder} DVDs and " +
                  $"{noOfGamesInOrder} games");
Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");

