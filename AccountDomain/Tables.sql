CREATE TABLE account.customers (
	customersid serial PRIMARY KEY,
	name varchar(255) NOT NULL,
	email varchar(255) NOT NULL
);

CREATE TABLE account.orders (
	ordersid serial PRIMARY KEY,
	price double precision NOT NULL,
	createdDate date NOT NULL,
	customerid integer REFERENCES account.customers(customersid) ON DELETE CASCADE
);