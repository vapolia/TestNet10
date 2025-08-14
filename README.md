# Demo app to demonstrate layout issues

## 1. Android+Windows

Issue:
- CollectionView items don't appear correctly

Repro steps:
- Windows (Windows 11) or Android (API 36)
- Open the 3 column page
- Tap the 1st button to add 1 or more items
- Tap the 2nd button to display the 3rd column with the CollectionView

Result:
- No item appears. You have to scroll down to see the 1st item.

Expected:
- All items appears directly.

## 2. Android

Issue:
- Navigation bar is under the top edge of the screen (under the notch)

Repro steps:
- Windows (Windows 11) or Android (API 36)

Result:
- Navigation bar is under the top edge of the screen (under the notch)

Expected:
- Navigation bar is below the notch, as SafeAreaEdges equals All for both the ContentPage and the Grid.

## 3. iOS (issue in progress)

ISSUE IN PROGRESS. CURRENTLY EXTRACTING CODE FROM ANOTHER PROJECT.

Issue:
- Adding an item to the CollectionView freezes the app

Repro steps:
- (in progress)

Result:
- app freezes (you can check the counter: it stops)

Expected:
- app do not freeze

