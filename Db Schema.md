Tables: 

- FAQCategory

	| Field Type | Field Name | Keys
	| --- | --- | --- |
	| Guid | Id | Primary Key |
	| string | CategoryEn |  |
	| string | CategoryAr |  |
	| List<FAQ> | FAQs | Navigation Property |

- FAQ

	| Field Type | Field Name | Keys
	| --- | --- | --- |
	| Guid | Id | Primary Key |
	| string | QuestionEn |  |
	| string | QuestionAr |  |
	| string | AnswerEn |  |
	| string | AnswerAr |  |
	| Guid | FAQCategoryId | Foreign Key => (FAQCategory.Id) |
	| bool | IsActive |  |

- ProductCategory

	| Field Type | Field Name | Keys
	| --- | --- | --- |
	| Guid | Id | Primary Key |
	| string | CategoryNameEn |  |
	| string | CategoryNameAr |  |
	| List<Product> | Products | Navigation Property |
	| bool | IsActive |  |

- Product

	| Field Type | Field Name | Keys
	| --- | --- | --- |
	| Guid | Id | Primary Key |
	| string | ProductNameEn |  |
	| string | ProductNameAr |  |
	| double | Price |  |
	| string | DescriptionEn |  |
	| string | DescriptionAr |  |
	| Guid | ProductCategoryId | Foreign Key => (ProductCategory.Id) |
	| bool | IsActive |  |

- Inventory

	| Field Type | Field Name | Keys
	| --- | --- | --- |
	| Guid | Id | Primary Key |
	| Guid | ProductId | Foreign Key => (Product.Id) |
	| int | Quantity |  |
	| DateTime | LastUpdated |  |
	| bool | IsActive |  |

- Order

	| Field Type | Field Name | Keys
	| --- | --- | --- |
	| Guid | Id | Primary Key |
	| DateTime | OrderDate |  |
	| double | TotalPrice |  |
	| Guid | Customer | Foreign Key => (Customer.Id) |
	| List<OrderItem> | OrderItems | Navigation Property |
	| bool | IsActive |  |

- OrderItem
	
	| Field Type | Field Name | Keys
	| --- | --- | --- |
	| Guid | Id | Primary Key |
	| Guid | OrderId | Foreign Key => (Order.Id) |
	| Guid | ProductId | Foreign Key => (Product.Id) |
	| int | Quantity |  |
	| double | TotalPrice |  |
	| bool | IsActive |  |


- Need To Do
	- User
	- Customer
	- Admin

Relationships:

| Relation Type | Tables Involved 
| --- | --- |
| One to Many | Customer to Order |
| One to Many | ProductCategory to Product |
| One to Many | FAQCategory to FAQ |
| One to Many | Order to OrderItem |
| One to One | Inventory to Product |
| One to One | OrderItem to Product |
