import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

test_name = "Archive"
 
class TestArchive(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    def test_001_Assert_Hover(self):
        LoginUser("GiantTestUser","123456")

        wait(Archive.ul_archive, 10).highlight(1)
        hover(Archive.ul_archive)
    '''
    def test_002_WebDesign(self):
        Test_WebDesign()

    def test_003_AlgoAcademy(self):
        Test_AlgoAcademy()
		
    def test_004_TestCategory(self):
        Test_TestCategory()
		
    def test_005_SchoolAcademy(self):
        Test_SchoolAcademy()
		
    #def test_006_Programming(self):
        #Test_Programming()
    '''
    def test_007_WebDesignAndUI(self):
        TestMainArchiveItemWithNoChildren(Archive.li_web_ui, Archive.web_li_hovered)

    def test_008_SoftwareTechnologies(self):
        TestMainArchiveItemWithNoChildren(Archive.li_software_technnology, Archive.software_hovered)

    def test_009_EditCat(self):
        TestMainArchiveItemWithNoChildren(Archive.li_edit_cat, Archive.edit_cat_hovered)

    def test_10_Hey(self):
        TestMainArchiveItemWithNoChildren(Archive.li_hey, Archive.hey_hovered)

    def test_11_Category(self):
        TestMainArchiveItemWithNoChildren(Archive.li_category, Archive.category_hovered)
        click(Log.button_logout)
        closeApp("chrome")

if __name__ == '__main__':
    LogTestResults(test_name, TestArchive)

