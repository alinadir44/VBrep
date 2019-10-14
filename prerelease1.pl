character(jim).
character(jenny).
character(habib).
character(gwen).
character_type(habib,explorer).
character_type(jim,prince).
character_type(jenny,princess).
character_type(gwen,detective).
has_skill(jim,fly).
has_skill(jenny,invisibility).
has_skill(habib,timetravel).
has_skill(gwen,telepathy).
pet(jim,horse).
pet(jenny,bird).
pet(habib,fish).
pet(gwen, bird).
animal(horse).
animal(fish).
animal(bird).
skill(fly).
skill(invisibility).
skill(timetravel).
skill(telepathy).

has_skill(X,Y):- character(X),skill(Y).

has_pet(X,Y):- character(X),pet(Y).

