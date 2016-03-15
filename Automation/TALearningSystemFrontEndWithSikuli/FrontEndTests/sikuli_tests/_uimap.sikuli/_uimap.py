########################################################
# UI map for XYZ
########################################################
from sikuli import *
########################################################    
class TALS:
    button_login = Pattern("button_login.png").similar(0.67)
    field_username = "field_username.png"
    field_password = "field_password.png"
    
    button_entry = "button_entry.png"
    giant_test_user_logo = "giant_test_user_logo.png"
    fresh_new_user_logo = "fresh_new_user_logo.png"
    my_courses = Pattern("my_courses.png").similar(0.90)
    course_dsa = "course_dsa.png"
    course_dsa_logo = "course_dsa_logo.png"
    button_logout = Pattern("button_logout.png").similar(0.90)
    giant_test_user_home_logo = "giant_test_user_home_logo.png"
    fresh_new_user_home_logo = "fresh_new_user_home_logo.png"
    no_courses_menu = "no_courses_menu.png"
    c_sharp_part_two = "c_sharp_part_two.png"
    test_course_two = "test_course_two.png"
    course_c_sharp_part_two_logo = "course_c_sharp_two_logo.png"
    test_course_two_logo = "test_course_two_logo.png"
    navigation_button_course = "navigation_button_course.png"

class Log:
    label_logoTelerik = "label_logoTelerik.png"
    label_username = Pattern("label_username.png").targetOffset(323,5)
    label_password = Pattern("label_password.png").targetOffset(407,5)
    button_entry = Pattern("button_entry.png").similar(0.90)
    button_login = "button_login.png"
    giant_test_user_logo = "giant_test_user_logo.png"
    button_logout = Pattern("button_logout.png").similar(0.83)
    
   
class Archive:
    logo_TelerikAcademy="logo_TelerikAcademy.png"
    ul_archive=Pattern("ul_archive.png").similar(0.57)
    
    li_WebDesign_notHovered=Pattern("li_WebDesign_notHovered.png").similar(0.98)
    li_WebDesign_Hovered=Pattern("li_WebDesign_Hovered.png").similar(0.97)
    subLi_2222_notHovered=Pattern("subLi_2222_notHovered.png").similar(0.98)
    subLi_2222_Hovered=Pattern("subLi_2222_Hovered.png").similar(0.98)
    
    li_AlgoAcademy_notHovered=Pattern("li_AlgoAcademy_notHovered.png").similar(0.91)
    li_AlgoAcademy_Hovered=Pattern("li_AlgoAcademy_Hovered.png").similar(0.98)
    
    li_SchoolAcademy_notHovered="li_SchoolAcademy_notHovered.png"
    li_SchoolAcademy_Hovered="li_SchoolAcademy_Hovered.png"
    
    li_TestCategory_notHovered=Pattern("li_TestCategory_notHovered.png").similar(0.97)
    li_TestCategory_Hovered=Pattern("li_TestCategory_Hovered.png").similar(0.98)
    TestCategory_3222_notHovered=Pattern("TestCategory_3222_notHovered.png").similar(0.98)
    TestCategory_3222_Hovered=Pattern("TestCategory_3222_Hovered.png").similar(0.98)
    _3222_TestKategoria2012_notHovered=Pattern("3222_TestKategoria2012_notHovered.png").exact()
    _3222_TestKategoria2012_Hovered=Pattern("3222_TestKategoria2012_Hovered.png").similar(0.97)
    TestKategoria2012_CSharp2012_notHovered=Pattern("TestKategoria2012_CSharp_notHovered.png").similar(0.98)
    TestKategoria2012_CSharp2012_Hovered=Pattern("TestKategoria2012_CSharp2012_Hovered.png").similar(0.97)

    li_Programming_notHovered=Pattern("li_Programming_notHovered.png").similar(0.98)
    li_Programming_Hovered=Pattern("li_Programming_Hovered.png").similar(0.98)

    li_web_ui = "web_ui.png"
    web_li_hovered = "web_hovered.png"

    li_software_technnology = "software_technologies.png"
    software_hovered = "softweare_hovered.png"

    li_edit_cat = "edit_cat.png"
    edit_cat_hovered = "edit_cat_hovered.png"

    li_hey ="hey.png"
    hey_hovered = "hey_hovered.png"

    li_category = "category.png"
    category_hovered ="category_hovered.png"

class Courses:
    label_courses = Pattern("label_courses.png").similar(0.59)
    archer_homework_eval = "archer.png"
    title_archer_course = "title_archer_course.png"
    test_course_two = "test_course_two.png"
    title_course_tow ="title_course_tow.png"
    export_test_course = "exportTestCourse.png"
    title_export_test = "title_export_test.png"
    test_course_one = "testCourseOne.png"
    title_course_one = "title_course_one.png"
    data_base = "dataBase.png"
    title_data_base = "title_data_base.png"

class StudentsInCourses:
    tille = "tille.png"
    button_add = "button_add.png"
 
    title_form ="title_form.png"
    input_username = "input_username.png"
    button_choose = "button_choose_course.png"
    buttone_hovered = "buttone_hovered.png"
 
    
class CreateCourse:
    button_admin = "button_admin.png"
    button_instance = "button_Instance.png"
    button_add_new_instance = "button_addnewinstance.png"
    form_input_course = Pattern("form_input_course.png").targetOffset(160,0)
    form_input_name = Pattern("form_input_name.png").targetOffset(160,0)
    form_input_desc = Pattern("form_input_desc.png").targetOffset(200,100)
    form_licence_dropdown = Pattern("form_licence_dropdown.png").targetOffset(200,0)
    form_licence_option = "form_licence_option.png"
    form_category = "form_category.png"
    form_input_start_date = Pattern("form_input_start_date.png").targetOffset(160,0)
    form_input_end_date = Pattern("form_input_end_date.png").targetOffset(160,0)
    form_checkbox_active = Pattern("form_checkbox_active.png").targetOffset(148,-4)
    form_checkbox_visible = Pattern("form_checkbox_visible.png").targetOffset(155,-5)
    form_input_lectures = Pattern("form_input_lectures.png").similar(0.90).targetOffset(170,0)
    form_button_update = "form_button_update.png"
    navigation_sikuli_button = "navigation_sikuli_button.png"
    

class Admin:
    button_admin = "botton_admin.png"
    button_students_statistics_by_age = "button_studets_statistics_by_age.png"

class StudentsStatisticsByAge:
    menu_select_course = "menu_select_course.png"
    menu_years_select = "menu_years_select.png"
    select_all_courses = "select_all_courses.png"
    one_year_range = "one_year_range.png"
    two_years_range = "two_years_range.png"
    three_years_range = "three_year_range.png"
    five_years_range = "five_years_graph.png"
    ten_years_range = "ten_years_graph.png"
    select_ten_years = "select_ten_years.png"
    select_three_years = "select_three_years.png"
    select_two_years = "select_two_years.png"
    select_one_year = "select_one_year.png"
    menu_years_range_select = "menu_years_range_select.png"

    
    
     