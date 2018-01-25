show tables;

#----- COLUMNS
show columns from publishers;
show columns from authors;
show columns from languages;
show columns from countries;
show columns from genres;
show columns from users;

#----- SELECTS *
select * from countries;
select * from languages;
select * from countries;
select * from authors;		
select * from publishers;
select * from users;

delete from authors where author_id = 2;

#----- COUNTS
select count(*) from authors;
select count(*) from publishers;
select count(*) from languages;
select count(*) from genres;



#----- JOINS
select p.*, c.* from publishers p join countries c on p.country_id = c.country_id;

select count(*) from authors;
select a.authorName, c.countryName, l.languageName from authors a
 join countries c on a.country_id = c.country_id
 join languages l on a.language_id = l.language_id;
 
select p.*, c.* from publishers p left join countries c on p.country_id = c.country_id; 
 

insert into authors (authorName, authorPhoto) values ("Lucas", "C:\Users\lucas\Desktop");
insert into users (userName, userPassword, userAccess, userDateRegister) values ("Lucas", "123", "Administrador", current_timestamp()); 