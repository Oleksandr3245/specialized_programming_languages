% client(Name, Segment).
% usage_profile(Name, CallsPerMonth, GbPerMonth, NightGb, RoamingNeed).
% tariff(Id, MinCalls, MaxCalls, MinGb, MaxGb, NightIncluded, RoamingIncluded, Price).
% heavy_user(Name).
% internet_oriented(Name).
% call_oriented(Name).
% recommended_tariff(Name, TariffId).
% best_tariff(Name, TariffId).
% all_recommended_tariffs(Name, List).
% advise_tariff(Name, TariffId).

client(anna, regular).
client(oleg, vip).
client(ivan, new).
client(maria, regular).
client(petro, regular).
client(iryna, vip).
client(andrii, regular).

% usage_profile(Name, Calls, Gb, NightGb, Roaming)

usage_profile(anna, 80, 25, 5, no).
usage_profile(oleg, 400, 120, 30, yes).
usage_profile(ivan, 30, 8, 2, no).
usage_profile(maria, 250, 15, 3, no).
usage_profile(petro, 60, 70, 20, no).
usage_profile(iryna, 500, 200, 50, yes).
usage_profile(andrii, 150, 40, 15, no).




% tariff(Id, MinCalls, MaxCalls, MinGb, MaxGb, NightIncluded, RoamingIncluded, Price)

tariff(light, 0, 100, 0, 10, no, no, 150).
tariff(standard, 50, 250, 10, 50, no, no, 250).
tariff(internet_plus, 0, 200, 30, 100, yes, no, 350).
tariff(business, 200, 600, 20, 150, yes, yes, 500).
tariff(premium, 300, 1000, 100, 300, yes, yes, 700).



heavy_user(Name) :-
    usage_profile(Name, Calls, Gb, _, _),
    Calls > 300,
    Gb > 100.

internet_oriented(Name) :-
    usage_profile(Name, Calls, Gb, _, _),
    Gb > Calls.

call_oriented(Name) :-
    usage_profile(Name, Calls, Gb, _, _),
    Calls > Gb.




fits_tariff(Name, TariffId) :-
    usage_profile(Name, Calls, Gb, NightGb, RoamingNeed),
    tariff(TariffId, MinC, MaxC, MinG, MaxG, NightInc, RoamingInc, _),
    Calls >= MinC,
    Calls =< MaxC,
    Gb >= MinG,
    Gb =< MaxG,
    (NightGb =< 10 ; NightInc = yes),
    (RoamingNeed = no ; RoamingInc = yes).


recommended_tariff(Name, premium) :-
    client(Name, vip),
    heavy_user(Name).




recommended_tariff(Name, internet_plus) :-
    internet_oriented(Name),
    usage_profile(Name, _, Gb, _, _),
    Gb > 50.


recommended_tariff(Name, business) :-
    call_oriented(Name),
    usage_profile(Name, Calls, _, _, yes),
    Calls > 200.

recommended_tariff(Name, light) :-
    client(Name, new).



recommended_tariff(Name, standard) :-
    client(Name, regular),
    usage_profile(Name, Calls, Gb, _, _),
    Calls =< 200,
    Gb =< 50.

recommended_tariff(Name, TariffId) :-
    fits_tariff(Name, TariffId).


all_recommended_tariffs(Name, List) :-
    findall(T,
            recommended_tariff(Name, T),
            List).

advise_tariff(Name, Tariff) :-
    recommended_tariff(Name, Tariff).


advise_best_tariff(Name, Tariff) :-
    best_tariff(Name, Tariff).



