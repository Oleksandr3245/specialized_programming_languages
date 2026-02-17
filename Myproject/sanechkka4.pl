male(anton).
male(antony).
male(volodymyr).
male(voldemar).
male(gena).
male(genadya).

female(marta).
female(anna).
female(sasha).
female(nastya).
female(olya).
female(inna).


parent(anton, volodymyr).
parent(anton, anna).
parent(marta, volodymyr).
parent(marta, anna).

parent(volodymyr, sasha).
parent(volodymyr, nastya).
parent(olya, sasha).
parent(olya, nastya).

parent(anna, voldemar).
parent(gena, voldemar).

married(anton, marta).
married(volodymyr, olya).
married(gena, anna).

grandparent(X, Z) :- 
    parent(X, Y), 
    parent(Y, Z). 

sibling(X, Y) :- 
    parent(P, X), 
    parent(P, Y), 
    X \= Y.