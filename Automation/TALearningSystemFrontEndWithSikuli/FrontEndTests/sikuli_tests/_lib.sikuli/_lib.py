from sikuli import *
import HTMLTestRunner
import unittest
bdLibPath = os.path.abspath(sys.argv[0] + "..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _uimap import *

def LogTestResults(projectName, testClass):
    suite = unittest.TestLoader().loadTestsFromTestCase(testClass)

    outfile = open("report_" + projectName + "_.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title=projectName)
    runner.run(suite)
    outfile.close()

def RunBrowser():
    type("d", KEY_WIN)
    sleep(1)
    type("r", KEY_WIN)
    sleep(0.5)
    paste("chrome http://stage.telerikacademy.com/")
    sleep(0.5)
    type(Key.ENTER)

def LogInTALS():
    RunBrowser()
    wait(TALS.button_login, 30)
    if exists(TALS.button_login):
        click(TALS.button_login)
        wait(TALS.field_username, 30)
        paste(TALS.field_username, "GiantTestUser")
        type(Key.ESC)
        paste(TALS.field_password, "123456")
        click(TALS.button_entry)

def LoginUser(username, password):
    RunBrowser()
    wait(Log.label_logoTelerik, 15)

    if exists(Log.button_logout):
        click(Log.button_logout)

    wait(Log.button_entry, 15)
    click(Log.button_entry)
    wait(Log.label_username, 30)

    click(Log.label_username)
    for i in range(20):
        type(Key.BACKSPACE)
    paste(Log.label_username, username)
    type(Key.ESC)

    click(Log.label_password)
    for i in range(20):
        type(Key.BACKSPACE)
    paste(Log.label_password, password)
    type(Key.ESC)
    click(Log.button_login)

def TestMainArchiveItemWithNoChildren(Item_notHovered, Item_Hovered):
    wait(Item_notHovered,5).highlight(1)
    hover(Item_notHovered)
    wait(Item_Hovered,5).highlight(1)

def TestChildren(Parent_Hovered, Children_notHovered, Children_Hovered):
    find(Parent_Hovered).right().find(Children_notHovered).highlight(1)
    hover(Children_notHovered)
    wait(Children_Hovered,5).highlight(1)

def Test_WebDesign():
    TestMainArchiveItemWithNoChildren(Archive.li_WebDesign_notHovered, Archive.li_WebDesign_Hovered)
    TestChildren(Archive.li_WebDesign_Hovered, Archive.subLi_2222_notHovered, Archive.subLi_2222_Hovered)

def Test_AlgoAcademy():
    TestMainArchiveItemWithNoChildren(Archive.li_AlgoAcademy_notHovered,Archive.li_AlgoAcademy_Hovered)

def Test_TestCategory():
    TestMainArchiveItemWithNoChildren(Archive.li_TestCategory_notHovered,Archive.li_TestCategory_Hovered)
    TestChildren(Archive.li_TestCategory_Hovered, Archive.TestCategory_3222_notHovered, Archive.TestCategory_3222_Hovered)
    TestChildren(Archive.TestCategory_3222_Hovered, Archive._3222_TestKategoria2012_notHovered, Archive._3222_TestKategoria2012_Hovered)
    TestChildren(Archive._3222_TestKategoria2012_Hovered, Archive.TestKategoria2012_CSharp2012_notHovered, Archive.TestKategoria2012_CSharp2012_Hovered)

def Test_SchoolAcademy():
    TestMainArchiveItemWithNoChildren(Archive.li_SchoolAcademy_notHovered,Archive.li_SchoolAcademy_Hovered)

#def Test_Programming():

def TestMainArchiveItemWithNoChildren(Item_notHovered, Item_Hovered):
    wait(Item_notHovered,5).highlight(1)
    hover(Item_notHovered)
    wait(Item_Hovered,5).highlight(1)

def TestChildren(Parent_Hovered, Children_notHovered, Children_Hovered):
    find(Parent_Hovered).right().find(Children_notHovered).highlight(1)
    hover(Children_notHovered)
    wait(Children_Hovered,5).highlight(1)

def Test_WebDesign():
    TestMainArchiveItemWithNoChildren(Archive.li_WebDesign_notHovered, Archive.li_WebDesign_Hovered)
    TestChildren(Archive.li_WebDesign_Hovered, Archive.subLi_2222_notHovered, Archive.subLi_2222_Hovered)

def Test_AlgoAcademy():
    TestMainArchiveItemWithNoChildren(Archive.li_AlgoAcademy_notHovered,Archive.li_AlgoAcademy_Hovered)

def Test_TestCategory():
    TestMainArchiveItemWithNoChildren(Archive.li_TestCategory_notHovered,Archive.li_TestCategory_Hovered)
    TestChildren(Archive.li_TestCategory_Hovered, Archive.TestCategory_3222_notHovered, Archive.TestCategory_3222_Hovered)
    TestChildren(Archive.TestCategory_3222_Hovered, Archive._3222_TestKategoria2012_notHovered, Archive._3222_TestKategoria2012_Hovered)
    TestChildren(Archive._3222_TestKategoria2012_Hovered, Archive.TestKategoria2012_CSharp2012_notHovered, Archive.TestKategoria2012_CSharp2012_Hovered)

def Test_SchoolAcademy():
    TestMainArchiveItemWithNoChildren(Archive.li_SchoolAcademy_notHovered,Archive.li_SchoolAcademy_Hovered)

def Test_Programming():
    TestMainArchiveItemWithNoChildren(Archive.li_Programming_notHovered,Archive.li_Programming_Hovered)

def OpenCourse(course,title):
    type(Key.PAGE_UP)
    hover(Courses.label_courses)
    wait(course,5)
    click(course)
    sleep(2)
    while(not exists(title)):
        wheel(WHEEL_DOWN,5)
    hover(title)

def OpenMyCourses():
    wait(TALS.giant_test_user_home_logo, 30)
    hover(TALS.giant_test_user_home_logo)
    wait(TALS.my_courses, 3)
    hover(TALS.my_courses)

def AddNewInstance(activity, visibility):
    RunBrowser()
    LoginUser("GiantTestUser", "123456")
    wait(CreateCourse.button_admin, 15)
    click(CreateCourse.button_admin); sleep(5)
    while not exists(CreateCourse.button_instance):
        wheel(WHEEL_DOWN, 5)
    click(CreateCourse.button_instance)
    while not exists(CreateCourse.button_add_new_instance):
        wheel(WHEEL_DOWN, 5)
    click(CreateCourse.button_add_new_instance)
    click(CreateCourse.form_input_course)
    type("frend" + Key.ENTER)
    click(CreateCourse.form_input_name)
    type("Sikuli")
    click(CreateCourse.form_input_desc)
    type("Sikuli cant write Bulgarian")
    click(CreateCourse.form_licence_dropdown); sleep(1)
    click(CreateCourse.form_licence_option); sleep(1)
    while not exists(CreateCourse.form_category):
        wheel(WHEEL_DOWN, 2)

    click(CreateCourse.form_category)
    while not exists(CreateCourse.form_input_start_date):
        wheel(WHEEL_DOWN, 2)
    click(CreateCourse.form_input_start_date)
    type("23/01/2016")

    while not exists(CreateCourse.form_input_end_date):
        wheel(WHEEL_DOWN, 2)
    click(CreateCourse.form_input_end_date)
    type("24/01/2016")

    if(activity):
        while not exists(CreateCourse.form_checkbox_active):
            wheel(WHEEL_DOWN, 2)
        click(CreateCourse.form_checkbox_active)

    if(visibility):
        while not exists(CreateCourse.form_checkbox_visible):
            wheel(WHEEL_DOWN, 2)
        click(CreateCourse.form_checkbox_visible)

    while not exists(CreateCourse.form_input_lectures):
        wheel(WHEEL_DOWN, 2)
    click(CreateCourse.form_input_lectures)
    type("10")

    while not exists(CreateCourse.form_button_update):
        wheel(WHEEL_DOWN, 2)
    click(CreateCourse.form_button_update).highlight(2)

def ExpandCoursesNavigation():
    type("r", KEY_CTRL); sleep (3)
    while not exists(TALS.navigation_button_course):
        wheel(WHEEL_UP, 2)
    hover(TALS.navigation_button_course); sleep(1)