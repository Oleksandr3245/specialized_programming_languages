my_length([], 0).

my_length([_|Tail], N) :-
    my_length(Tail, N1),
    N is N1 + 1.

sum_list([], 0).

sum_list([Head|Tail], Sum) :-
    sum_list(Tail, TailSum),
    Sum is Head + TailSum.

max_list([X], X).

max_list([Head|Tail], Max) :-
    max_list(Tail, TailMax),
    (   Head > TailMax
    ->  Max = Head      
    ;   Max = TailMax    
    ).

map_square([], []).

map_square([Head|Tail], [HeadSq|TailSq]) :-
    HeadSq is Head * Head,
    map_square(Tail, TailSq).

edge(kyiv, lviv).
edge(lviv, uzhhorod).
edge(kyiv, odessa).
edge(odessa, lviv).
edge(lviv, ternopil).
edge(ternopil, chernivtsi).

path(A, B) :-
    edge(A, B).

path(A, B) :-
    edge(A, X),
    path(X, B).

path_length(A, B, 1) :-
    edge(A, B).

path_length(A, B, L) :-
    edge(A, X),
    path_length(X, B, L1),
    L is L1 + 1.