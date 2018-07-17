Feature: CreateCommunity

Scenario Outline: Creates new Community
Given Open Browser'<Browser>' and navigate to Emblim website
When a user signIn '<UserName>' with Password '<password>'
And create a new community 
And fill community fields with community name '<CommunityName>' 
Then the community created '<ExpectedResult>' successfully
Examples: 
| UserName | password  | CommunityName | Browser | ExpectedResult |
| senthil9 | Orange123 | A Two         | firefox | A Two          |

Scenario Outline: create community without Game Age & Language
Given Open Browser'<Browser>' and navigate to Emblim website
When a user signIn '<UserName>' with Password '<password>'
And create a new community 
And create with community name '<CommunityName>' but dont fill required fields game,age and language 
Then the community'<CommunityName>' not created successfully
Examples: 
| UserName | password  | CommunityName | Browser |
| senthil9 | Orange123 | A Three       | firefox  |