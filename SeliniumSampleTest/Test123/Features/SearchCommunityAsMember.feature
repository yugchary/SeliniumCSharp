Feature: SearchCommunityAsMember

Scenario Outline: Search community as a member
Given Open Browser'<Browser>' and navigate to Emblim website
When a user signIn '<username>' with Password '<password>'
And search a community with community name contain '<communityName>'
Then i should see the community'<ExpectedCommunityName>' in my result
Examples: 
| communityName | username | password  | Browser | ExpectedCommunityName |
| Test          | senthil9 | Orange123 | firefox  | Test1                 |        