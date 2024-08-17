Tables: 

- branches

	| Field Type | Field Name | Keys
	| --- | --- | --- |
	| Guid | Id | Primary Key |
	| string | BranchLocation |  |
	| string | BranchDescription |  |
	| string | BranchPhoneNumber |  |
	| string | BranchPictureURL |  |
	| List<rooms> | Rooms | Navigation Property |
	| List<rooms_branches> | BranchRooms | Navigation Property |
	| bool | IsActive |  |

Relationships:

| Relation Type | Tables Involved 
| --- | --- |
| One to Many | branches to branch_pictures |
