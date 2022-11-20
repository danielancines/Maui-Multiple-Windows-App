# Maui Multiple Windows With Community Popup Concept

- **Feature**: Using Multiple Windows on a Maui Multiplataform App, I need to use a  [CommunityToolkit Popup](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/views/popup), but who invoke the Popup is a Page, its parent, like Main Page. 
- **Problem**: How to do this using [MVVM](https://learn.microsoft.com/pt-br/windows/uwp/data-binding/data-binding-and-mvvm), because the ViewModel doesn't know who it is attached?

The first idea is: create a **PopupService** who will have all pages and subscribe it to be used inside ViewModel, to invoke a Popup on its attached View.

