Public Class Form2
    '    الدليل التقني للربط مع نظام الفوترة
    'الوطني
    'اعداد
    'ي
    'الالك رتو ن ي
    'لنظام الفوترة الوط ن ي
    'لجنة تقديم الدعم الف ن
    '2023
    'الدليل التقني للربط مع نظام الفوترة الوطني
    'من خلال واجهة برمجة التطبيقات (API)( 1.4 )
    'دائرة ضريبة الدخل والمبيعات
    '2 الدليل التقني للربط مع نظام الفوترة الوطني
    'رقم الاصدار نوع الوثيقة تاريخ الاصدار
    '1.1 مسودة
    '2023/1/12
    '1.2 مسودة
    '16 / 1 / 2023
    '1.3 معتمدة
    '23 / 1 / 2023
    '1.4 معتمدة
    '2023/12/01
    'أعد من قبل/ أعضاء لجنة تقديم الدعم الفني لنظام الفوترة الوطني الالكتروني :
    'الاسم مكان العمل رقم الموبايل البريد الالكتروني
    'فادي الحمد دائرة ضريبة الدخل والمبيعات
    '0790122303
    'Fadi.h@istd.gov.joخلدون أبو يمن دائرة ضريبة الدخل والمبيعات
    '0799058372
    'Khaldoon.a@istd.gov.jo
    'م.محمد الغرابلي دائرة ضريبة الدخل والمبيعات
    '0789187087
    'Mohammad.ga@istd.gov.jo
    'بمشاركة كل من:
    'معتمد من قبل :
    'جهة الاعتماد التاريخ
    'مديرية وحدة شؤون الفوترة 01/12/2023
    'الاسم مكان العمل الاسم مكان العمل
    'م.أحمد الجواودة ضريبة الدخل والمبيعات هبه أبو عجوة ضريبة الدخل والمبيعات
    'م.أحمد شعلان ضريبة الدخل والمبيعات مجدي العشا
    'دائرة ضريبة الدخل والمبيعات
    '3 الدليل التقني للربط مع نظام الفوترة الوطني
    'جدول المحتويات
    'التسجيل على نظام الفوترة 5 .............................................................................................................................. تسلسل الإجراءات لإرسال الفاتورة 8 ........................................................................................................................... 1(مكونات ملف 9 .............................................................................................................................. JSON(2 مكونات الفاتورة الالك رتونية بصيغة 9 .............................................................................................................. XMLأولاً: فاتورة الدخل 10 ............................................................................................................................ .A معلومات الفاتورة الأساسية . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .......................... ................................ ................................ 11.B البيانات الخاصة بالبائع )المكلف( . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .................... ................................ ................................ 13.C البيانات الخاصة بالمشتري . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ........................... ................................ ................................ 14.D البيانات الخاصة بتسلسل مصدر الدخل للبائع )المكلف( . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ............................ ................................ 16.E المدخلات الخاصة بإجمالي فاتورة الدخل . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ........... ................................ ................................ 17.F المدخلات الخاصة بتفاصيل سلع فاتورة الدخل . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ...... ................................ ................................ 19
    'ثانيا:ً فاتورة ارجاع الدخل . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .......... ................................ ................................ ................................ 31.A معلومات فاتورة الارجاع والفاتورة المراد الارجاع منها . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .......................... ................................ 22.B البيانات الخاصة بالبائع )المكلف( . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .................... ................................ ................................ 24.C البيانات الخاصة بالمشتري . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ........................... ................................ ................................ 25.D البيانات الخاصة بتسلسل مصدر الدخل للبائع )المكلف( . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ............................ ................................ 26
    '.E سبب الارجاع . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ......... ................................ ................................ ................................ 26
    '.F المدخلات الخاصة بإجمالي فاتورة ارجاع الدخل . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ... ................................ ................................ 27.G المدخلات الخاصة بتفاصيل فاتورة ارجاع الدخل . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .. ................................ ................................ 29
    'ثالث ا:ً فاتورة المبيعات العامة . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ........ ................................ ................................ ................................ 31.A معلومات الفاتورة الأساسية . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .......................... ................................ ................................ 32.B البيانات الخاصة بالبائع )المكلف( . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .................... ................................ ................................ 34.C البيانات الخاصة بالمشتري . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ........................... ................................ ................................ 35.D البيانات الخاصة بتسلسل مصدر الدخل للبائع )المكلف( . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ............................ ................................ 37.E المدخلات الخاصة بإجمالي الفاتورة العامة . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .......... ................................ ................................ 38.F المدخلات الخاصة بتفاصيل سلع الفاتورة العامة . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .... ................................ ................................ 40
    'رابع ا:ً فاتورة ارجاع المبيعات العامة . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .............................. ................................ ................................ 43.A معلومات الفاتورة الأساسية . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .......................... ................................ ................................ 44
    '.B معلومات الفاتورة المراد الارجاع منها . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .............. ................................ ................................ 45.C البيانات الخاصة بالبائع )المكلف( . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .................... ................................ ................................ 46.D البيانات الخاصة بالمشتري . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .......................... ................................ ................................ 47.E البيانات الخاصة بتسلسل مصدر الدخل للبائع )المكلف( . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ............................ ................................ 48
    'دائرة ضريبة الدخل والمبيعات
    '4 الدليل التقني للربط مع نظام الفوترة الوطني
    '.F سبب الارجاع . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ......... ................................ ................................ ................................ 48
    '.G مجموع الخصم . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ...... ................................ ................................ ................................ 49
    '.H مجموع قيمة الضريبة المراد ارجاعها . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .............. ................................ ................................ 49.I المدخلات الخاصة بإجمالي فاتورة الارجاع . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ......... ................................ ................................ 51.J المدخلات الخاصة بتفاصيل فاتورة الارجاع . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ......... ................................ ................................ 52
    'خامس ا:ً فاتورة المبيعات الخاصة . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ... ................................ ................................ ................................ 56.A معلومات الفاتورة الأساسية . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .......................... ................................ ................................ 57.B البيانات الخاصة بالبائع )المكلف( . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .................... ................................ ................................ 59.C البيانات الخاصة بالمشتري . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ........................... ................................ ................................ 60.D البيانات الخاصة بتسلسل مصدر الدخل للبائع )المكلف( . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ............................ ................................ 62.E المدخلات الخاصة بإجمالي الفاتورة الخاصة . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ........ ................................ ................................ 63.F المدخلات الخاصة بتفاصيل سلع الفاتورة الخاصة . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .. ................................ ................................ 65
    'سادس ا:ً فاتورة ارجاع المبيعات الخاصة . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ........................... ................................ ................................ 69.A معلومات الفاتورة الأساسية . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .......................... ................................ ................................ 70
    '.B معلومات الفاتورة المراد الارجاع منها . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .............. ................................ ................................ 71
    '.C البيانات الخاصة بالبائع )المكلف( . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .................... ................................ ................................ 72.D البيانات الخاصة بالمشتري . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .......................... ................................ ................................ 73.E البيانات الخاصة بتسلسل مصدر الدخل للبائع )المكلف( . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ............................ ................................ 74
    '.F سبب الارجاع . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ......... ................................ ................................ ................................ 74
    '.G المدخلات الخاصة بإجمالي فاتورة الارجاع الخاصة . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . ............................... ................................ 75.H المدخلات الخاصة بتفاصيل فاتورة الارجاع الخاصة . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .............................. ................................ 77
    '(3 تجهيز وارسال ملف JSON 81 ............................................................................................................................
    'دائرة ضريبة الدخل والمبيعات
    '5 الدليل التقني للربط مع نظام الفوترة الوطني
    'التسجيل على نظام الفوترة
    'بعد اتمام عملية التسجيل يجب المتابعة بالشكل التالي:
    '1 . يقوم المكلف بالدخول الى نظام الفوترة من خلال الشاشة التالية:
    'ملاحظة
    'للتسجيل على نظام الفوترة وإنشاء حساب على نظام الفوترة، يرىج الاطلاع على دليل اجراءات الانضمام إلى نظام
    'ي
    'الأرد ن ي
    'الإلكرتو ن ي
    'الفوترة الوط ن المنشور على الموقع http://www.istd.gov.johttp://www.istd.gov.johttp://www.istd.gov.johttp://www.istd.gov.johttp://www.istd.gov.jo http://www.istd.gov.johttp://www.istd.gov.johttp://www.istd.gov.johttp://www.istd.gov.johttp://www.istd.gov.jo http://www.istd.gov.johttp://www.istd.gov.jo http://www.istd.gov.johttp://www.istd.gov.johttp://www.istd.gov.jo http://www.istd.gov.jo
    'دائرة ضريبة الدخل والمبيعات
    '6 الدليل التقني للربط مع نظام الفوترة الوطني
    '2 . الضغط على ايقونة ربط الاجهزة ثم الضغط على ربط جديد
    '3 . تعبئة اسم المستخدم واختيار تسلسل مصدر الدخل ثم الضغط على اضافة
    'دائرة ضريبة الدخل والمبيعات
    '7 الدليل التقني للربط مع نظام الفوترة الوطني
    '4 . سيقوم النظام تلقائيا بإنشاء رقم المستخدم ) Client ID ( و المفتاح السري (Secret Key)
    'دائرة ضريبة الدخل والمبيعات
    '8 الدليل التقني للربط مع نظام الفوترة الوطني
    'تسلسل الإجراءات لإرسال الفاتورة
    'تسلسل الاجراءات لعملية ارسال الفاتورة الالك رتونية
    'من خلال
    'الربط مع نظام الفوترة الوط ن
    'ي
    'يتم ارسال الفوات رت الالك ر تونية من خلال الربط مع نظام الفوترة الوط ن حسب المخطط التا ي لى
    'مخطط يوضح تسلسل الاجراءات لعملية ارسال الفاتورة الالكترونية من خلال الربط مع نظام الفوترة الوطني
    'دائرة ضريبة الدخل والمبيعات
    '9 الدليل التقني للربط مع نظام الفوترة الوطني
    '1 ) مكونات ملف JSON
    'للقيام ببناء الفاتورة الالك رتونية وتجه ر تها للإرسال بصيغة ملف JSON ، يجب أن تحتوي على 3 مكونات:
    'a . Client ID b . Secret Key c . الفاتورة بصيغة XML
    '2 ) مكونات الفاتورة الالك رتونية بصيغة XML تم اعتماد معيار ) UBL 2.1 Invoice ( كهيكل للفاتورة الالك رتونية، والعناصر أدناه تمثل بداية ملف XML والمراجع اللازمة لمعالجة
    'هذا الملف بحسب معيار ) UBL 2.1 :)
    '<?xml version="1.0" encoding="UTF-8"?> <Invoice xmlns="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2" xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2" xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2" xmlns:ext="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"> <cbc:ProfileID>reporting:1.0</cbc:ProfileID>
    'وفيما يلي شرح تفصيلي لكل مكون من مكونات الفاتورة الالكترونية بصيغة XML حسب نوع المكلف:
    '❖فاتورة الدخل : للمكلفين غير المسجلين في ضريبة المبيعات.
    '•نموذج انشاء فاتورة دخل
    '•نموذج فاتورة ارجاع الدخل
    '❖ فاتورة المبيعات : للمكلفين المسجلين في ضريبة المبيعات.
    '•نموذج انشاء فاتورة المبيعات
    '•نموذج فاتورة ارجاع المبيعات
    '❖نموذج فاتورة المبيعات الخاصة : للمكلفين المسجلين في ضريبة المبيعات الخاصة.
    '•نموذج انشاء فاتورة الخاصة
    '•نموذج فاتورة ارجاع المبيعات الخاصة
    'ملاحظة
    'يتم الحصول على Client IDClient ID Client IDClient IDClient IDClient ID و Secret Key Secret KeySecret Key ي
    'نظام الفوترة الوط ن ي
    'من شاشة ربط الأجهزة الموجودة ف
    'دائرة ضريبة الدخل والمبيعات
    '10 الدليل التقني للربط مع نظام الفوترة الوطني
    'أولا ا: فاتورة الدخل
    'دائرة ضريبة الدخل والمبيعات
    '11 الدليل التقني للربط مع نظام الفوترة الوطني
    'العناصر المظللة باللون الأصفر في الأمثلة أدناه تدل على متغيرات مطلوب تعبئتها )إجبارية( من خلال نظام البائع.
    'أما العناصر المظللة باللون الأخضر تدل على متغيرات مطلوب تعبئتها )إختيارية( من خلال نظام البائع.
    'وباقي العناصر وصف ثابت بدون تغيير.
    'A . معلومات الفاتورة الأساسية
    '<cbc:ID> رقم الفاتورة </cbc:ID> <cbc:UUID> رقم متسلسل </cbc:UUID> <cbc:IssueDate>تاري خ الفاتورة </cbc:IssueDate> <cbc:InvoiceTypeCode name="طريقة الدفع ">388</cbc:InvoiceTypeCode> <cbc:Note>ملاحظة او وصف الفاتورة </cbc:Note>
    '<cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode>
    '<cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode>
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>عداد الفاتورة </cbc:UUID>
    '</cac:AdditionalDocumentReference> الوصف XML Element يتم ادخال رقم الفاتورة هنا <cbc:ID> رقم الفاتورة </cbc:ID> رقم مم ر ت UUID (Universal Unique Identifier) يتم
    'انشاؤه من قبل نظام المكلف بحيث يشكل ID و UUID
    'معا مفتاحا رئيسيا ) Primary Key ( لعدم تكرار الفاتورة
    'المرسلة على النظام
    '<cbc:UUID>رقم متسلسل </cbc:UUID> تاري خ الفاتورة ويجب ان يكون حسب الصيغة التالية
    'yyyy-mm-dd مثال 2022-12-31 <cbc:IssueDate>تاري خ الفاتورة </cbc:IssueDate> - خاصية name ي ه للدلالة على طريقة الدفع )نقدي،
    'ذمم(
    'ي هذا المثال تخص فوات رت الدخل فقط.
    'الكودات الواردة ف
    'الرقم 388 للدلالة على انها فاتورة جديدة و ي الجدول
    'كما ف
    'أدناه
    '<cbc:InvoiceTypeCode name="طريقة الدفع ">
    '388
    '</cbc:InvoiceTypeCode>
    'إنشاء فاتورة جديدة نقدية <cbc:InvoiceTypeCode name="011">388</cbc:InvoiceTypeCode> انشاء فاتورة ذمم <cbc:InvoiceTypeCode name="021">388</cbc:InvoiceTypeCode>
    'تستخدم لإضافة اي ملاحظات او وصف للفاتورة او
    'ي توثيقها.
    'اي بيانات برغب البائع ف
    '<cbc:Note>ملاحظة او وصف الفاتورة </cbc:Note>
    'عداد للفاتورة يتم انشاؤه من قبل المكلف
    'عداد يتم إنشاؤه من قبل المكلف للفوات رت الإلك رتونية يبدأ
    'بشكل تسلس ل من 1 الى مالانهاية حسب التعريف العال م (
    'ملاحظة:
    'يرغب بها
    'يمكن للمكلف انشاء تسلسل بالطريقة ال ر ن
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>عداد الفاتورة </cbc:UUID>
    '</cac:AdditionalDocumentReference>
    'دائرة ضريبة الدخل والمبيعات
    '12 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cbc:ID>EIN00001</cbc:ID> <cbc:UUID>0043e15e-740b-4e1b-889d-504afdb1d1d</cbc:UUID> <cbc:IssueDate>2023-10-30</cbc:IssueDate> <cbc:InvoiceTypeCode name="011">388</cbc:InvoiceTypeCode> <cbc:Note> ملاحظات </cbc:Note> <cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode> <cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:AdditionalDocumentReference> <cbc:ID>ICV</cbc:ID> <cbc:UUID>1</cbc:UUID> </cac:AdditionalDocumentReference>
    'دائرة ضريبة الدخل والمبيعات
    '13 الدليل التقني للربط مع نظام الفوترة الوطني
    'B . البيانات الخاصة بالبائع )المكلف(
    '<cac:AccountingSupplierParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme> <cbc:CompanyID>الرقم الضريبي للبائع </cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName>اسم البائع </cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingSupplierParty> الوصف XML Element الرقم ال ضيى ي ن الخاص بالمكلف )البائع( <cbc:CompanyID>الرقم ال ضيى ي ن للبائع </cbc:CompanyID> ي صريبة الدخل
    'اسم البائع كما هو مسجل ف
    'والمبيعات
    '<cbc:RegistrationName>اسم البائع </cbc:RegistrationName> مثال
    '<cac:AccountingSupplierParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>12345678</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName>ال ر شكة الفنية لبيع المستلزمات </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingSupplierParty>
    'دائرة ضريبة الدخل والمبيعات
    '14 الدليل التقني للربط مع نظام الفوترة الوطني
    'C . البيانات الخاصة بالمشتري
    '<cac:AccountingCustomerParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID schemeID="النوع ">الرقم </cbc:ID>
    '</cac:PartyIdentification>
    '<cac:PostalAddress> <cbc:PostalZone>الرمز ال ىتيدي </cbc:PostalZone>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName>اسم المشرتي </cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '<cac:AccountingContact> <cbc:Telephone>رقم الهاتف </cbc:Telephone>
    '</cac:AccountingContact>
    '</cac:AccountingCustomerParty> الوصف XML Element يتم ادخال احدى الخيارات الخاصة ببيانات المشرتي وعلى
    'ان تكون فقط
    'أرقام وحسب الجدول التا ي لى :
    '<cbc:ID schemeID="النوع ">الرقم </cbc:ID>
    'النوع الرقم
    'NINي للمشرتي
    'الرقم الوط ن
    'PN ي
    'الارد ن الرقم الشخ ي ص لغ رت
    'TN الرقم ال ضيى ي ن للمشرتي
    'ملاحظة
    'ي حال كانت الفاتورة )ذمم( او كانت قيمة الفاتورة )النقدية( أكرت من ع رسرة الاف دينار
    'اسم المشرتي اجباري ف
    'دائرة ضريبة الدخل والمبيعات
    '15 الدليل التقني للربط مع نظام الفوترة الوطني
    'الوصف XML Element
    'الرمز ال ىتيدي للمشرتي <cbc:PostalZone> الرمز ال ىتيدي </cbc:PostalZone> اسم المشرتي <cbc:RegistrationName> اسم المشرتي </cbc:RegistrationName> رقم هاتف المشرتي <cbc:Telephone> رقم هاتف المشرتي </cbc:Telephone> مثال
    '<cac:AccountingCustomerParty> <cac:Party> <cac:PartyIdentification> <cbc:ID schemeID="TN">555555</cbc:ID> </cac:PartyIdentification> <cac:PostalAddress> <cbc:PostalZone>1234</cbc:PostalZone> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName>أحمد محمد </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> <cac:AccountingContact> <cbc:Telephone>777888999</cbc:Telephone> </cac:AccountingContact> </cac:AccountingCustomerParty>
    'دائرة ضريبة الدخل والمبيعات
    '16 الدليل التقني للربط مع نظام الفوترة الوطني
    'D . البيانات الخاصة بتسلسل مصدر الدخل للبائع )المكلف(
    'الوصف XML Element تسلسل مصدر الدخل )النشاط( للمكلف )البائع(
    '<cac:SellerSupplierParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID>تسلسل مصدر الدخل </cbc:ID>
    '</cac:PartyIdentification>
    '</cac:Party>
    '</cac:SellerSupplierParty> مثال
    '<cac:SellerSupplierParty> <cac:Party> <cac:PartyIdentification> <cbc:ID>9932895</cbc:ID> </cac:PartyIdentification> </cac:Party> </cac:SellerSupplierParty>
    'دائرة ضريبة الدخل والمبيعات
    '17 الدليل التقني للربط مع نظام الفوترة الوطني
    'E . المدخلات الخاصة بإجمالي فاتورة الدخل
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">مجموع قيمة الخصم دينار اردني </cbc:Amount>
    '</cac:AllowanceCharge>
    '<cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">اجمالي الفاتورة قبل الخصم </cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">اجمالي الفاتورة </cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">مجموع قيمة الخصم </cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">اجمالي الفاتورة </cbc:PayableAmount>
    '</cac:LegalMonetaryTotal> الوصف XML Element مجموع قيمة خصم السلع حيث ان النظام لا يقبل
    'الخصم على الفاتورة بشكل عام
    '<cbc:Amount currencyID="JO"> مجموع قيمة الخصم دينار اردني
    '</cbc:Amount> ملاحظة: في حال كان نظام المكلف يحسب الخصم على اجمالي الفاتورة يجب ان يتم توزيع الخصم على السلع و الخدمات قبل ترحيل
    'البيانات الى نظام الفوترة.
    'اجمالي الفاتورة قبل الخصم <cbc:TaxExclusiveAmount currencyID="JO">
    'اجمالي الفاتورة قبل الخصم
    '</cbc:TaxExclusiveAmount>
    'اجمالي الفاتورة قبل الخصم = مجموع )السعر * الكمية( لجميع معلومات السلع و الخدمات في الفاتورة
    'اجمالي الفاتورة <cbc:TaxInclusiveAmount currencyID="JO">
    'اجمالي الفاتورة
    '</cbc:TaxInclusiveAmount> اجمالي الفاتورة = اجمالي الفاتورة قبل الخصم – مجموع قيمة الخصم
    'مجموع قيمة الخصم <cbc:AllowanceTotalAmount currencyID="JO">
    'مجموع قيمة الخصم
    '</cbc:AllowanceTotalAmount>
    'مجموع قيمة الخصم= مجموع قيمة الخصم للسلع و الخدمات
    'اجمالي الفاتورة <cbc:PayableAmount currencyID="JO">
    'اجمالي الفاتورة
    '</cbc:PayableAmount> اجمالي الفاتورة = اجمالي الفاتورة قبل الخصم – مجموع قيمة الخصم
    'دائرة ضريبة الدخل والمبيعات
    '18 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> <cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">66.00</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">64.00</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">2.00</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">64.00</cbc:PayableAmount> </cac:LegalMonetaryTotal>
    'دائرة ضريبة الدخل والمبيعات
    '19 الدليل التقني للربط مع نظام الفوترة الوطني
    'F . المدخلات الخاصة بتفاصيل سلع فاتورة الدخل
    '<cac:InvoiceLine> <cbc:ID> رقم تسلس ي لى </cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">الكمية </cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:LineExtensionAmount>
    '<cac:Item> <cbc:Name>وصف السلعة او الخدمة </cbc:Name>
    '</cac:Item>
    '<cac:Price> <cbc:PriceAmount currencyID="JO"> سعر الوحدة </cbc:PriceAmount>
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO"> قيمة الخصم </cbc:Amount>
    '</cac:AllowanceCharge>
    '</cac:Price>
    '</cac:InvoiceLine> الوصف XML Element هو رقم تسلس ي لى خاص لكل )سلعة أو خدمة(
    'لا يتكرر على مستوى الفاتورة الواحدة
    '<cbc:ID> رقم تسلس ي لى </cbc:ID> الكمية للسلعة أو الخدمة الواحدة <cbc:InvoicedQuantity unitCode="PCE">
    'الكمية
    '</cbc:InvoicedQuantity> المبلغ الاجما ي لى للسلعة أو الخدمة =
    'سعر الوحدة * الكمية – خصم السلعة أو الخدمة
    '<cbc:LineExtensionAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:LineExtensionAmount> يتم وضع اسم السلعة او الخدمة او وصفها <cbc:Name> وصف السلعة او الخدمة </cbc:Name> سعر السلعة او الخدمة <cbc:PriceAmount currencyID="JO">
    'سعر الوحدة
    '</cbc:PriceAmount> يتم اضافة قيمة الخصم للسلعة أو الخدمة ان
    'ي من اجما ي لى سعر السلعة
    'وجد بالدينار الارد ن أو
    'الخدمة
    '<cbc:Amount currencyID="JO"> قيمة الخصم
    '</cbc:Amount>
    'دائرة ضريبة الدخل والمبيعات
    '20 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cac:InvoiceLine>==➔ بداية )السلعة أو الخدمة( الأولى
    '<cbc:ID>1</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">33.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">64.00</cbc:LineExtensionAmount> <cac:Item> <cbc:Name> Biscuit </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">2.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine> <cac:InvoiceLine> ==➔ بداية )السلعة أو الخدمة( الثانية
    '<cbc:ID>2</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">10.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">45.00</cbc:LineExtensionAmount> <cac:Item> <cbc:Name> Choclate </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">5.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">5.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'ملاحظة
    'ي المثال
    'يمكن إضافة أكرت من )سلعة أو خدمة( وذلك بتكرار بيانات) الخدمة أو السلعة( المراد إضافتها كما يظهر ف
    'اعلاه
    'دائرة ضريبة الدخل والمبيعات
    '21 الدليل التقني للربط مع نظام الفوترة الوطني
    'ثانياا: فاتورة ارجاع الدخل
    'دائرة ضريبة الدخل والمبيعات
    '22 الدليل التقني للربط مع نظام الفوترة الوطني
    'العناصر المظللة باللون الأصفر في الأمثلة أدناه تدل على متغيرات مطلوب تعبئتها )إجبارية( من خلال نظام البائع.
    'أما العناصر المظللة باللون الأخضر تدل على متغيرات مطلوب تعبئتها )إختيارية( من خلال نظام البائع.
    'وباقي العناصر وصف ثابت بدون تغيير.
    'A . معلومات فاتورة الأرجاع والفاتورة المراد الارجاع منها
    '<cbc:ID> رقم فاتورة الارجاع </cbc:ID> <cbc:UUID> رقم متسلسل لفاتورة الارجاع </cbc:UUID> <cbc:IssueDate>تاري خ فاتورة الارجاع </cbc:IssueDate> <cbc:InvoiceTypeCode name="طريقة الدفع ">381</cbc:InvoiceTypeCode> <cbc:Note>ملاحظة او وصف فاتو رة الارجاع </cbc:Note>
    '<cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode>
    '<cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:BillingReference>
    '<cac:InvoiceDocumentReference> <cbc:ID>رقم الفاتورة الاصلية المراد الارجاع منها </cbc:ID> <cbc:UUID>الرقم الخاص بالفاتورة الاصلية المراد الارجاع منها </cbc:UUID> <cbc:DocumentDescription>القيمة الاجمالية للفاتورة الاصلية المراد الارجاع منها
    '</cbc:DocumentDescription>
    '</cac:InvoiceDocumentReference>
    '</cac:BillingReference>
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>عداد الفاتورة </cbc:UUID>
    '</cac:AdditionalDocumentReference> الوصف XML Element يتم ادخال رقم فاتورة الارجاع هنا <cbc:ID> رقم فاتورة الارجاع </cbc:ID> رقم مم ر ت UUID (Universal Unique Identifier) يتم
    'انشاؤه من قبل نظام المكلف
    'بحيث يشكل ID و UUID معا مفتاحا رئيسيا
    '( Primary Key ( لعدم تكرار الفاتورة المرسلة على النظام
    '<cbc:UUID> رقم متسلسل لفاتورة الارجاع </cbc:UUID> تاري خ الفاتورة ويجب ان يكون حسب الصيغة التالية yyyy-mm-dd مثال 2022-12-31<cbc:IssueDate> تاري خ فاتورة الارجاع
    '</cbc:IssueDate>
    'ملاحظة
    'تكون عملية الارجاع المسموح بها ضمن ال رسروط التالية:
    '1. يسمح النظام بالارجاع على الكميات فقط.
    '2. ي الفاتورة الاصلية.
    'لا يسمح النظام بتجاوز الكمية المباعة ف
    '3. يسمح النظام للمكلف بإرسال فاتورة ارجاع على الفاتورة الاصلية مرة واحدة او اكرت حرن انتهاء جميع كميات
    'ي الفاتورة الاصلية.
    'المواد المباعة ف
    'دائرة ضريبة الدخل والمبيعات
    '23 الدليل التقني للربط مع نظام الفوترة الوطني
    '- خاصية name ي ه للدلالة على طريقة الدفع )نقدي، ذمم(
    'ي الجدول أدناه,
    'كما ف
    'الرقم 381 للدلالة على انها فاتورة ارجاع,
    'ي هذا الجدول تخص فوات رت
    'الكودات الواردة ف الدخل فقط.
    '<cbc:InvoiceTypeCode name="طريقة الدفع ">
    '381
    '</cbc:InvoiceTypeCode>
    'انشاء فاتورة ارجاع نقدي <cbc:InvoiceTypeCode name="011">381</cbc:InvoiceTypeCode> انشاء فاتورة ارجاع ذمم <cbc:InvoiceTypeCode name="021">381</cbc:InvoiceTypeCode>
    'تستخدم لإضافة اي ملاحظات او وصف للفاتورة او اي
    'ي توثيقها.
    'بيانات برغب البائع ف
    '<cbc:Note> ملاحظة او وصف فاتورة الارجاع
    '</cbc:Note>
    'رقم الفاتورة الاصلية المراد الارجاع منها <cac:BillingReference>
    '<cac:InvoiceDocumentReference> <cbc:ID> رقم الفاتورة الاصلية المراد الارجاع
    'منها </cbc:ID> رقم ال ) UUID ( الخاص بالفاتورة الاصلية المراد الارجاع
    'منها
    '<cbc:UUID> الرقم الخاص بالفاتورة الاصلية المراد
    'الارجاع منها
    '</cbc:UUID> القيمة الاجمالية للفاتورة الاصلية المراد الارجاع منها <cbc:DocumentDescription> القيمة الاجمالية للفاتورة
    'الاصلية المراد الارجاع منها
    '</cbc:DocumentDescription> </cac:InvoiceDocumentReference>
    '</cac:BillingReference> عداد للفاتورة يتم انشاؤه من قبل المكلف
    'عداد يتم إنشاؤه من قبل المكلف للفوات رت الإلك رت ونية يبدأ بشكل
    'تسلس ل من 1 الى مالانهاية حسب التعريف العال م (
    'ملاحظة:
    'يرغب بها
    'يمكن للمكلف انشاء تسلسل بالطريقة ال ر ن
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>عداد الفاتورة </cbc:UUID>
    '</cac:AdditionalDocumentReference> مثال
    '<cbc:ID>EIN00002</cbc:ID> <cbc:UUID>8055b137-a128-46d6-9421-8c2a6de57465</cbc:UUID> <cbc:IssueDate>2023-11-01</cbc:IssueDate> <cbc:InvoiceTypeCode name="011">381</cbc:InvoiceTypeCode> <cbc:Note>ملاحظات </cbc:Note> <cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode> <cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:BillingReference> <cac:InvoiceDocumentReference> <cbc:ID>EIN00001</cbc:ID> <cbc:UUID>0043e15e-740b-4e1b-889d-504afdb1d1d</cbc:UUID> <cbc:DocumentDescription>64.000</cbc:DocumentDescription> </cac:InvoiceDocumentReference> </cac:BillingReference> <cac:AdditionalDocumentReference> <cbc:ID>ICV</cbc:ID> <cbc:UUID>2</cbc:UUID> </cac:AdditionalDocumentReference>
    'دائرة ضريبة الدخل والمبيعات
    '24 الدليل التقني للربط مع نظام الفوترة الوطني
    'B . البيانات الخاصة بالبائع )المكلف(
    '<cac:AccountingSupplierParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme> <cbc:CompanyID>الرقم الضريبي للبائع </cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName>اسم البائع </cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingSupplierParty> الوصف XML Element الرقم ال ضيى ي ن الخاص بالمكلف )البائع( <cbc:CompanyID> الرقم ال ضيى ي ن
    'للبائع </cbc:CompanyID> ي صريبة الدخل والمبيعات
    'اسم البائع كما هو مسجل ف <cbc:RegistrationName> اسم
    'البائع </cbc:RegistrationName> مثال
    '<cac:AccountingSupplierParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>12345678</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName>ال ر شكة الفنية لبيع المستلزمات </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingSupplierParty>
    'دائرة ضريبة الدخل والمبيعات
    '25 الدليل التقني للربط مع نظام الفوترة الوطني
    'C . البيانات الخاصة بالمشتري) وصف ثابت دون تغيير او إضافة(
    '<cac:AccountingCustomerParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingCustomerParty> مثال
    '<cac:AccountingCustomerParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingCustomerParty>
    'ي فاتورة الإرجاع
    'بيانات المشرتي تكون من الفاتورة الأصلية حيث لا تعديل عليها ف
    'دائرة ضريبة الدخل والمبيعات
    '26 الدليل التقني للربط مع نظام الفوترة الوطني
    'D . البيانات الخاصة بتسلسل مصدر الدخل للبائع )المكلف(
    'الوصف XML Element تسلسل مصدر الدخل )النشاط( للمكلف )البائع(
    '<cac:SellerSupplierParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID>تسلسل مصدر الدخل </cbc:ID>
    '</cac:PartyIdentification>
    '</cac:Party>
    '</cac:SellerSupplierParty> مثال
    '<cac:SellerSupplierParty> <cac:Party> <cac:PartyIdentification> <cbc:ID>9932895</cbc:ID> </cac:PartyIdentification> </cac:Party> </cac:SellerSupplierParty>
    'E . سبب الارجاع
    'الوصف XML Element يجب ادخال
    'سبب الارجاع
    '<cac:PaymentMeans>
    '<cbc:PaymentMeansCode listID="UN/ECE 4461">10</cbc:PaymentMeansCode> <cbc:InstructionNote> سبب الارجاع </cbc:InstructionNote>
    '</cac:PaymentMeans> مثال
    '<cac:PaymentMeans> <cbc:PaymentMeansCode listID="UN/ECE 4461">10</cbc:PaymentMeansCode> <cbc:InstructionNote>تم الارجاع بسبب خلل في المنتج </cbc:InstructionNote> </cac:PaymentMeans>
    'دائرة ضريبة الدخل والمبيعات
    '27 الدليل التقني للربط مع نظام الفوترة الوطني
    'F . المدخلات الخاصة بإجمالي قيمة الكميات المراد ارجاعها
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">مجموع قيمة الخصم دينار اردني </cbc:Amount>
    '</cac:AllowanceCharge>
    '<cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">اجمالي فاتورة الارجاع قبل الخصم
    '</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">اجمالي فاتورة الارجاع </cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">مجموع قيمة الخصم </cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">اجمالي فاتورة الارجاع </cbc:PayableAmount>
    '</cac:LegalMonetaryTotal> الوصف XML Element مجموع قيمة خصم السلع حيث ان النظام لا يقبل الخصم على الفاتورة
    'بشكل عام
    '<cbc:Amount currencyID="JO"> مجموع قيمة الخصم دينار اردني
    '</cbc:Amount> اجمالي فاتورة الارجاع قبل الخصم <cbc:TaxExclusiveAmount
    'currencyID="JO"> اجمالي فاتورة الارجاع قبل الخصم
    '</cbc:TaxExclusiveAmount> اجمالي فاتورة الارجاع قبل الخصم = مجموع )السعر * الكمية( لجميع معلومات السلع و الخدمات المراد ارجاعها
    'اجمالي فاتورة الارجاع <cbc:TaxInclusiveAmount
    'currencyID="JO"> اجمالي فاتورة الارجاع
    '</cbc:TaxInclusiveAmount> اجمالي فاتورة الارجاع = اجمالي فاتورة الارجاع قبل الخصم – مجموع قيمة الخصم
    'مجموع قيمة الخصم <cbc:AllowanceTotalAmount
    'currencyID="JO"> مجموع قيمة الخصم
    '</cbc:AllowanceTotalAmount>
    'مجموع قيمة الخصم= مجموع قيمة الخصم للسلع و الخدمات المراد ارجاعها
    'اجمالي فاتورة الارجاع <cbc:PayableAmount currencyID="JO">
    'اجمالي فاتورة الارجاع
    '</cbc:PayableAmount> اجمالي فاتورة الارجاع = اجمالي فاتورة الارجاع قبل الخصم – مجموع قيمة الخصم
    'دائرة ضريبة الدخل والمبيعات
    '28 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> <cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">66.00</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">64.00</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">2.00</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">64.00</cbc:PayableAmount> </cac:LegalMonetaryTotal>
    'دائرة ضريبة الدخل والمبيعات
    '29 الدليل التقني للربط مع نظام الفوترة الوطني
    'G . المدخلات الخاصة بتفاصيل السلع المراد الارجاع منها
    '<cac:InvoiceLine> <cbc:ID> رقم تسلس ي لى </cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">الكمية المراد ارجاعها </cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:LineExtensionAmount>
    '<cac:Item> <cbc:Name>وصف السلعة او الخدمة </cbc:Name>
    '</cac:Item>
    '<cac:Price> <cbc:PriceAmount currencyID="JO"> سعر الوحدة </cbc:PriceAmount>
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO"> قيمة الخصم </cbc:Amount>
    '</cac:AllowanceCharge>
    '</cac:Price>
    '</cac:InvoiceLine> الوصف XML Element ي الفاتورة المراد الارجاع منها
    'رقم السلعة او الخدمة كما هو ف <cbc:ID> رقم تسلس ي لى </cbc:ID> الكمية للسلعة أو الخدمة المراد ارجاعها على ان لا تزيد عن
    'ي الفاتورة الاصلية
    'الكمية ف
    '<cbc:InvoicedQuantity unitCode="PCE"> الكمية المراد ارجاعها
    '</cbc:InvoicedQuantity> المبلغ الاجما ي لى للسلعة أو الخدمة =
    'سعر الوحدة * الكمية – خصم السلعة أو الخدمة
    '<cbc:LineExtensionAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:LineExtensionAmount> اسم السلعة او الخدمة او وصفه ا ي الفاتورة الاصلية
    'كما هو ف <cbc:Name> وصف السلعة او الخدمة </cbc:Name> سعر السلعة او الخدمة ي الفاتورة الاصلية
    'كما هو ف <cbc:PriceAmount currencyID="JO">
    'سعر الوحدة
    '</cbc:PriceAmount> قيمة الخصم للسلعة أو الخدمة ي من
    'ان وجد بالدينار الارد ن
    'اجما ي لى سعر السلعة أو الخدمة المرااد الارجاع منها
    '<cbc:Amount currencyID="JO"> قيمة الخصم
    '</cbc:Amount>
    'دائرة ضريبة الدخل والمبيعات
    '30 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cac:InvoiceLine>==➔ بداية )السلعة أو الخدمة( الأولى
    '<cbc:ID>1</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">33.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">64.00</cbc:LineExtensionAmount> <cac:Item> <cbc:Name> Biscuit </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">2.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine> <cac:InvoiceLine> ==➔ بداية )السلعة أو الخدمة( الثانية
    '<cbc:ID>2</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">33.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">64.00</cbc:LineExtensionAmount> <cac:Item> <cbc:Name> Choclate </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">2.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'ملاحظة
    'ي المثال اعلاه
    'يمكن إرجاع أكرت من )سلعة أو خدمة( وذلك بتكرار بيانات) الخدمة أو السلعة( المراد إرجاعها كما يظهر ف
    'دائرة ضريبة الدخل والمبيعات
    '31 الدليل التقني للربط مع نظام الفوترة الوطني
    'ثالث اا: فاتورة المبيعات العامة
    'دائرة ضريبة الدخل والمبيعات
    '32 الدليل التقني للربط مع نظام الفوترة الوطني
    'العناصر المظللة باللون الأصفر في الأمثلة أدناه تدل على متغيرات مطلوب تعبئتها )إجبارية( من خلال نظام البائع.
    'أما العناصر المظللة باللون الأخضر تدل على متغيرات مطلوب تعبئتها )إختيارية( من خلال نظام البائع.
    'وباقي العناصر وصف ثابت بدون تغيير.
    'A . معلومات الفاتورة الأساسية
    '<cbc:ID> رقم الفاتورة </cbc:ID> <cbc:UUID>رقم متسلسل </cbc:UUID> <cbc:IssueDate>تاري خ الفاتورة </cbc:IssueDate> <cbc:InvoiceTypeCode name="طريقة الدفع ">388</cbc:InvoiceTypeCode> <cbc:Note>ملاحظة او وصف الفاتورة </cbc:Note>
    '<cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode>
    '<cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode>
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>عداد الفاتورة </cbc:UUID>
    '</cac:AdditionalDocumentReference> الوصف XML Element يتم ادخال رقم الفاتورة هنا <cbc:ID> رقم الفاتورة </cbc:ID> رقم مم ر ت UUID (Universal Unique Identifier) يتم انشاؤه من قبل نظام
    'المكلف بحيث يشكل ID و UUID معا مفتاحا رئيسيا ) Primary Key ( لعدم
    'تكرار الفاتورة المرسلة على النظام
    '<cbc:UUID> رقم متسلسل </cbc:UUID> تاري خ الفاتورة ويجب ان يكون حسب الصيغة التالية yyyy-mm-dd مثال
    '2022-12-31<cbc:IssueDate>تاري خ الفاتورة </cbc:IssueDate> - خاصية name ي ه للدلالة على طريقة الدفع )نقدي، ذمم(
    'الكودات ي هذا المثال تخص فوات رت ال ضيبة العامة فقط.
    'الواردة ف
    'الرقم 388 للدلالة على انها فاتورة جديدة ي الجدول أدناه
    'كما ف
    '<cbc:InvoiceTypeCode name="طريقة الدفع "> 388
    '</cbc:InvoiceTypeCode>
    'إنشاء فاتورة جديدة نقدية <cbc:InvoiceTypeCode name="012">388</cbc:InvoiceTypeCode> انشاء فاتورة ذمم <cbc:InvoiceTypeCode name="022">388</cbc:InvoiceTypeCode>
    'تستخدم لإضافة اي ملاحظات او وصف للفاتورة او اي بيانات برغب
    'ي توثيقها.
    'البائع ف
    '<cbc:Note>ملاحظة او وصف الفاتورة </cbc:Note>
    'عداد للفاتورة يتم انشاؤه من قبل المكلف
    ')عداد يتم إنشاؤه من قبل المكلف للفوات رت الإلك رتونية يبدأ بشكل تسلس ل من 1 الى
    'مالانهاية حسب التعريف العال م (
    'ملاحظة:
    'يرغب بها
    'يمكن للمكلف انشاء تسلسل بالطريقة ال ر ن
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>عداد الفاتورة </cbc:UUID>
    '</cac:AdditionalDocumentReference>
    'دائرة ضريبة الدخل والمبيعات
    '33 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cbc:ID>EIN0001</cbc:ID> <cbc:UUID>0043e15e-740b-4e1b-889d-504afdb1d1d</cbc:UUID> <cbc:IssueDate>2023-11-20</cbc:IssueDate> <cbc:InvoiceTypeCode name="012">388</cbc:InvoiceTypeCode> <cbc:Note> ملاحظات </cbc:Note> <cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode> <cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:AdditionalDocumentReference> <cbc:ID>ICV</cbc:ID> <cbc:UUID>1</cbc:UUID> </cac:AdditionalDocumentReference>
    'دائرة ضريبة الدخل والمبيعات
    '34 الدليل التقني للربط مع نظام الفوترة الوطني
    'B . البيانات الخاصة بالبائع )المكلف(
    '<cac:AccountingSupplierParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme> <cbc:CompanyID>الرقم الضريبي للبائع </cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName>اسم البائع </cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingSupplierParty> الوصف XML Element الرقم ال ضيى ي ن الخاص بالمكلف )البائع( <cbc:CompanyID> الرقم ال ضيى ي ن للبائع </cbc:CompanyID> ي صريبة الدخل
    'اسم البائع كما هو مسجل ف
    'والمبيعات
    '<cbc:RegistrationName>اسم البائع </cbc:RegistrationName> مثال
    '<cac:AccountingSupplierParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>12345678</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName>ال ر شكة الفنية لبيع المستلزمات </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingSupplierParty>
    'دائرة ضريبة الدخل والمبيعات
    '35 الدليل التقني للربط مع نظام الفوترة الوطني
    'C . البيانات الخاصة بالمشتري
    '<cac:AccountingCustomerParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID schemeID="النوع ">الرقم </cbc:ID>
    '</cac:PartyIdentification>
    '<cac:PostalAddress> <cbc:PostalZone>الرمز ال ىتيدي </cbc:PostalZone> <cbc:CountrySubentityCode>المدينة </cbc:CountrySubentityCode>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme>
    '<cbc:CompanyID>1</cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName>اسم المشرتي </cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '<cac:AccountingContact> <cbc:Telephone>رقم الهاتف </cbc:Telephone>
    '</cac:AccountingContact>
    '</cac:AccountingCustomerParty> الوصف XML Element يتم ادخال احدى الخيارات الخاصة ببيانات المشرتي وعلى ان تكون فقط
    'أرقام وحسب الجدول التا ي لى
    '<cbc:ID schemeID="النوع ">الرقم </cbc:ID> النوع الرقم
    'NINي للمشرتي
    'الرقم الوط ن
    'PN ي
    'الارد ن الرقم الشخ ي ص لغ رت
    'TN الرقم ال ضيى ي ن للمشرتي
    'ملاحظة
    'اسم المشرتي فقط ي حال كانت الفاتورة )ذمم( او كانت قيمة الفاتورة )النقدية( أكرت من ع رسرة الاف دينار
    'اجباري ف
    'دائرة ضريبة الدخل والمبيعات
    '36 الدليل التقني للربط مع نظام الفوترة الوطني
    'الوصف XML Element
    'الرمز ال ىتيدي للمشرتي <cbc:PostalZone> الرمز ال ىتيدي </cbc:PostalZone> رمز المحافظة الخاصة بالمشرتي ويتم
    'استبدالها حسب الجدول التا ي لى
    'JO-BA البلقاء
    'JO-MN معان
    'JO-MD مادبا
    'JO-MA المفرق
    'JO-KA الكرك
    'JO-JA جرش
    'JO-IR إربد
    'JO-AZ الزرقاء
    'JO-AT الطفيلة
    'JO-AQ العقبة
    'JO-AM عمان
    'JO-AJ عجلون
    '<cbc:CountrySubentityCode> المدينة
    '</cbc:CountrySubentityCode>
    'اسم المشرتي <cbc:RegistrationName> اسم المشرتي </cbc:RegistrationName> رقم هاتف المشرتي <cbc:Telephone> رقم هاتف المشرتي </cbc:Telephone> مثال
    '<cac:AccountingCustomerParty> <cac:Party> <cac:PartyIdentification> <cbc:ID schemeID="TN">33445544</cbc:ID> </cac:PartyIdentification> <cac:PostalAddress> <cbc:PostalZone>33554</cbc:PostalZone> <cbc:CountrySubentityCode>JO-AZ</cbc:CountrySubentityCode> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>33445544</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName>احمد محمود </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> <cac:AccountingContact> <cbc:Telephone>324323434</cbc:Telephone> </cac:AccountingContact> </cac:AccountingCustomerParty>
    'دائرة ضريبة الدخل والمبيعات
    '37 الدليل التقني للربط مع نظام الفوترة الوطني
    'D . البيانات الخاصة بتسلسل مصدر الدخل للبائع )المكلف(
    'الوصف XML Element تسلسل مصدر الدخل )النشاط( للمكلف )البائع(
    '<cac:SellerSupplierParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID>تسلسل مصدر الدخل </cbc:ID>
    '</cac:PartyIdentification>
    '</cac:Party>
    '</cac:SellerSupplierParty> مثال
    '<cac:SellerSupplierParty> <cac:Party> <cac:PartyIdentification> <cbc:ID>9932895</cbc:ID> </cac:PartyIdentification> </cac:Party> </cac:SellerSupplierParty>
    'دائرة ضريبة الدخل والمبيعات
    '38 الدليل التقني للربط مع نظام الفوترة الوطني
    'E . المدخلات الخاصة بإجمالي الفاتورة العامة
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">مجموع قيمة الخصم دينار اردني </cbc:Amount>
    '</cac:AllowanceCharge>
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">مجموع قيمة الضريبة العامة </cbc:TaxAmount>
    '</cac:TaxTotal>
    '<cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">اجمالي الفاتورة قبل الخصم </cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">اجمالي الفاتورة </cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">مجموع قيمة الخصم </cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">اجمالي الفاتورة </cbc:PayableAmount>
    '</cac:LegalMonetaryTotal> الوصف XML Element مجموع قيمة خصم السلع حيث ان النظام لا يقبل الخصم
    'على الفاتورة بشكل عام
    '<cbc:Amount currencyID="JO"> مجموع قيمة الخصم دينار اردني
    '</cbc:Amount> ملاحظة: في حال كان نظام المكلف يحسب الخصم على اجمالي الفاتورة يجب ان يتم توزيع الخصم على السلع و الخدمات قبل
    'ترحيل البيانات الى نظام الفوترة.
    'مجموع قيمة الضريبة العامة <cbc:TaxAmount currencyID="JO">
    'مجموع قيمة الضريبة العامة
    '</cbc:TaxAmount> اجمالي الفاتورة قبل الخصم <cbc:TaxExclusiveAmount currencyID="JO">
    'اجمالي الفاتورة قبل الخصم
    '</cbc:TaxExclusiveAmount>
    'اجمالي الفاتورة قبل الخصم = مجموع )السعر * الكمية( لجميع معلومات السلع و الخدمات في الفاتورة
    'اجمالي الفاتورة <cbc:TaxInclusiveAmount currencyID="JO">
    'اجمالي الفاتورة
    '</cbc:TaxInclusiveAmount> اجمالي الفاتورة = )اجمالي الفاتورة قبل الخصم – مجموع قيمة الخصم + مجموع قيمة الضريبة العامة(
    'مجموع قيمة الخصم <cbc:AllowanceTotalAmount currencyID="JO">
    'مجموع قيمة الخصم
    '</cbc:AllowanceTotalAmount> مجموع قيمة الخصم= مجموع قيمة الخصم للسلع و الخدمات
    'اجمالي الفاتورة <cbc:PayableAmount currencyID="JO">
    'اجمالي الفاتورة
    '</cbc:PayableAmount> اجمالي الفاتورة = )اجمالي الفاتورة قبل الخصم – مجموع قيمة الخصم + مجموع قيمة الضريبة العامة(
    'دائرة ضريبة الدخل والمبيعات
    '39 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">4.48</cbc:TaxAmount> </cac:TaxTotal> <cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">66.00</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">68.48</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">2.00</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">68.48</cbc:PayableAmount> </cac:LegalMonetaryTotal>
    'دائرة ضريبة الدخل والمبيعات
    '40 الدليل التقني للربط مع نظام الفوترة الوطني
    'F . المدخلات الخاصة بتفاصيل سلع الفاتورة العامة
    '<cac:InvoiceLine> <cbc:ID> رقم تسلس ي لى </cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">الكمية </cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:LineExtensionAmount>
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">قيمة ال ضيبة للسلعة أو الخدمة </cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">المبلغ الاجما ي لى للسلعة أو الخدمة شامل ال ضيبة
    '</cbc:RoundingAmount>
    '<cac:TaxSubtotal> <cbc:TaxAmount currencyID="JO">قيمة ال ضيبة للسلعة أو الخدمة
    '</cbc:TaxAmount>
    '<cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>نسبة ال ضيبة العامة على السلعة أو الخدمة </cbc:Percent>
    '<cac:TaxScheme>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal>
    '</cac:TaxTotal>
    '<cac:Item> <cbc:Name>وصف السلعة او الخدمة </cbc:Name>
    '</cac:Item>
    '<cac:Price> <cbc:PriceAmount currencyID="JO"> سعر الوحدة قبل ال ضيبة </cbc:PriceAmount>
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO"> قيمة الخصم </cbc:Amount>
    '</cac:AllowanceCharge>
    '</cac:Price>
    '</cac:InvoiceLine> الوصف XML Element هو رقم تسلس ي لى خاص لكل )سلعة أو خدمة( <cbc:ID> رقم تسلس ي لى </cbc:ID> الكمية للسلعة أو الخدمة الواحدة <cbc:InvoicedQuantity unitCode="PCE">
    'الكمية
    '</cbc:InvoicedQuantity> المبلغ الاجما ي لى للسلعة أو الخدمة =
    'سعر الوحدة * الكمية – خصم السلعة أو الخدمة
    '<cbc:LineExtensionAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:LineExtensionAmount> قيمة ال ضيبة للسلعة أو الخدمة =
    ')المبلغ الاجما ي لى للسلعة أو الخدمة * نسبة ال ضيبة(
    '<cbc:TaxAmount currencyID="JO"> قيمة ال ضيبة للسلعة أو الخدمة
    '</cbc:TaxAmount>
    'دائرة ضريبة الدخل والمبيعات
    '41 الدليل التقني للربط مع نظام الفوترة الوطني
    'الوصف XML Element المبلغ الاجما ي لى للسلعة أو الخدمة شامل ال ضيبة=
    'المبلغ الاجما ي لى للسلعة أو الخدمة + قيمة ال ضيبة للسلعة أو
    'الخدمة
    '<cbc:RoundingAmount currencyID="JO"> المبلغ الاجما ي لى للسلعة أو الخدمة شامل ال ضيبة
    '</cbc:RoundingAmount> ي الجدول أدناه:
    'موضحة ف <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID>
    'القيمة الوصف نسبة ال ضيبة) Precent )
    'Zحال كانت السلعة او الخدمة معفية
    'ف 0
    'O حال كانت السلعة او الخدمة خاضعة لنسبة الصفر
    'ف 0
    'S حال كانت السلعة او الخدمة خاضعة لنسبة من النسب ال ضيبية ما عدا ال
    'ف 0 % 1,2,3,4,5,7,8,10,16.. نسبة ال ضيبة العامة على السلعة أو الخدمة وحسب النسب التالية
    '0 ,% 1 ,% 2 ,% 3 ,% 4 ,% 5 ,% 7 ,% 8 ,% 10 ,% 16 %
    'والصيغة تكون حسب الامثلة التالية:
    '<cbc:Percent>1</cbc:Percent>
    '<cbc:Percent>4</cbc:Percent>
    '<cbc:Percent>8</cbc:Percent>
    '<cbc:Percent>16</cbc:Percent><cbc:Percent> نسبة ال ضيبة العامة على السلعة أو الخدمة
    '</cbc:Percent> يتم وضع اسم السلعة او الخدمة او وصفها <cbc:Name> وصف السلعة او الخدمة </cbc:Name> سعر السلعة او الخدمة قبل ال ضيبة <cbc:PriceAmount currencyID="JO">
    'سعر الوحدة قبل ال ضيبة
    '</cbc:PriceAmount> يتم اضافة قيمة الخصم للسلعة أو الخدمة ي
    'ان وجد بالدينار الارد ن
    'من اجما ي لى سعر السلعة أو الخدمة
    '<cbc:Amount currencyID="JO"> قيمة الخصم
    '</cbc:Amount> مثال
    '<cac:InvoiceLine>==➔ بداية )السلعة أو الخدمة( الأولى )مثال على سلعة خاضعة لل ضيبة(
    '<cbc:ID>1</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">33.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">64.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">4.48</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">68.48</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxAmount currencyID="JO">4.48</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>7.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name> Biscuit </cbc:Name> </cac:Item> <cac:Price>
    'دائرة ضريبة الدخل والمبيعات
    '42 الدليل التقني للربط مع نظام الفوترة الوطني
    '<cbc:PriceAmount currencyID="JO">2.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine> <cac:InvoiceLine> ==➔ بداية )السلعة أو الخدمة( الثانية )مثال على سلعة معفية من ال ضيبة(
    '<cbc:ID>2</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">10.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">50.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">0.00</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">50.00</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxAmount currencyID="JO">0.00</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">Z</cbc:ID> <cbc:Percent>0.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name> Choclate </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">5.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">0.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'ملاحظة
    'ي المثال
    'يمكن إضافة أكرت من )سلعة أو خدمة( وذلك بتكرار بيانات) الخدمة أو السلعة( المراد إضافتها كما يظهر ف
    'اعلاه
    'دائرة ضريبة الدخل والمبيعات
    '43 الدليل التقني للربط مع نظام الفوترة الوطني
    'رابع اا: فاتورة ارجاع المبيعات العامة
    'دائرة ضريبة الدخل والمبيعات
    '44 الدليل التقني للربط مع نظام الفوترة الوطني
    'العناصر المظللة باللون الأصفر في الأمثلة أدناه تدل على متغيرات مطلوب تعبئتها )إجبارية( من خلال نظام البائع.
    'أما العناصر المظللة باللون الأخضر تدل على متغيرات مطلوب تعبئتها )إختيارية( من خلال نظام البائع.
    'وباقي العناصر وصف ثابت بدون تغيير.
    'A . معلومات الفاتورة الأساسية
    '<cbc:ID>رقم فاتورة الارجاع </cbc:ID> <cbc:UUID> رقم متسلسل لفاتورة الارجاع </cbc:UUID> <cbc:IssueDate>تاريخ فاتورة الارجاع </cbc:IssueDate> <cbc:InvoiceTypeCode name="طريقة الدفع ">381</cbc:InvoiceTypeCode>
    '<cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode>
    '<cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode>
    '<cac:BillingReference>
    '<cac:InvoiceDocumentReference> <cbc:ID>رقم الفاتورة الاصلية المراد الارجاع منها </cbc:ID> <cbc:UUID>الرقم المتسلسل للفاتورة الاصلية المراد الارجاع منها </cbc:UUID> <cbc:DocumentDescription>اجمالي الفاتورة الاصلية المراد الارجاع منها </cbc:DocumentDescription>
    '</cac:InvoiceDocumentReference>
    '</cac:BillingReference>
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>عداد الفاتورة </cbc:UUID>
    '</cac:AdditionalDocumentReference> الوصف XML Element يتم ادخال رقم الفاتورة هنا <cbc:ID> رقم فاتورة الارجاع </cbc:ID> رقم مم ر ت UUID (Universal Unique Identifier) يتم
    'انشاؤه من قبل نظام المكلف بحيث يشكل ID و UUID معا
    'مفتاحا رئيسيا ) Primary Key ( لعدم تكرار الفاتورة المرسلة
    'على النظام
    '<cbc:UUID> رقم متسلسل لفاتورة الارجاع </cbc:UUID> تاري خ الفاتورة ويجب ان يكون حسب الصيغة التالية yyyy-mm-dd مثال 2022-12-31<cbc:IssueDate>تاري خ فاتو رة الارجاع </cbc:IssueDate> - خاصية name ي ه للدلالة على طريقة الدفع )نقدي، ذمم(
    'ي هذا المثال تخص فوات رت
    'الكودات الواردة ف ال ضيبة العامة
    'فقط.
    'الرقم 381 يدل على انها فاتورة ارجاع ي الجدول أدناه
    'كما ف
    '<cbc:InvoiceTypeCode name="طريقة الدفع "> 381
    '</cbc:InvoiceTypeCode>
    'انشاء فاتورة ارجاع نقدي <cbc:InvoiceTypeCode name="012">381</cbc:InvoiceTypeCode> انشاء فاتورة ارجاع ذمم <cbc:InvoiceTypeCode name="022">381</cbc:InvoiceTypeCode>
    'دائرة ضريبة الدخل والمبيعات
    '45 الدليل التقني للربط مع نظام الفوترة الوطني
    'B . معلومات الفاتورة المراد الارجاع منها
    '<cac:BillingReference>
    '<cac:InvoiceDocumentReference> <cbc:ID>رقم الفاتورة الاصلية المراد الارجاع منها </cbc:ID> <cbc:UUID>الرقم المتسلسل للفاتورة الاصلية المراد الارجاع منها </cbc:UUID> <cbc:DocumentDescription>اجما ي لى الفاتورة الاصلية المراد الارجاع منها </cbc:DocumentDescription>
    '</cac:InvoiceDocumentReference>
    '</cac:BillingReference> الوصف XML Element رقم الفاتورة الاصلية المراد الارجاع منها <cbc:ID> رقم الفاتورة الاصلية المراد الارجاع منها </cbc:ID> الرقم المتسلسل للفاتورة الاصلية المراد الارجاع منها <cbc:UUID> الرقم المتسلسل للفاتورة الاصلية المراد الارجاع
    'منها </cbc:UUID>
    'اجما ي لى الفاتورة الاصلية المراد الارجاع منها <cbc:DocumentDescription> اجما ي لى الفاتورة الاصلية
    'المراد الارجاع منها </cbc:DocumentDescription> عداد للفاتورة يتم انشاؤه من قبل المكلف
    ')عداد يتم إنشاؤه من قبل المكلف للفوات رت الإلك رتونية يبدأ بشكل
    'تسلس ل من 1 الى مالانهاية حسب التعريف العال م (
    'ملاحظة:
    'يرغب بها
    'يمكن للمكلف انشاء تسلسل بالطريقة ال ر ن
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>عداد الفاتورة </cbc:UUID>
    '</cac:AdditionalDocumentReference> مثال
    '<cbc:ID>EIN0002</cbc:ID> <cbc:UUID>8055b137-a128-46d6-9421-8c2a6de57465</cbc:UUID> <cbc:IssueDate>2023-11-20</cbc:IssueDate> <cbc:InvoiceTypeCode name="012">381</cbc:InvoiceTypeCode> <cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode> <cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:BillingReference> <cac:InvoiceDocumentReference> <cbc:ID>EIN0001</cbc:ID> <cbc:UUID>0043e15e-740b-4e1b-889d-8504afdb1d1d2</cbc:UUID> <cbc:DocumentDescription>68.48</cbc:DocumentDescription> </cac:InvoiceDocumentReference> </cac:BillingReference> <cac:AdditionalDocumentReference> <cbc:ID>ICV</cbc:ID> <cbc:UUID>2</cbc:UUID> </cac:AdditionalDocumentReference>
    'دائرة ضريبة الدخل والمبيعات
    '46 الدليل التقني للربط مع نظام الفوترة الوطني
    'C . البيانات الخاصة بالبائع )المكلف(
    '<cac:AccountingSupplierParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme> <cbc:CompanyID>الرقم ال ضيى ي ن للبائع </cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName>اسم البائع </cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingSupplierParty> الوصف XML Element الرقم ال ضيى ي ن الخاص بالمكلف )البائع( <cbc:CompanyID> الرقم ال ضيى ي ن للبائع </cbc:CompanyID> ي صريبة الدخل
    'اسم البائع كما هو مسجل ف
    'والمبيعات
    '<cbc:RegistrationName>اسم البائع </cbc:RegistrationName> مثال
    '<cac:AccountingSupplierParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>12345678</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName>ال ر شكة الفنية للمبيعات </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingSupplierParty>
    'دائرة ضريبة الدخل والمبيعات
    '47 الدليل التقني للربط مع نظام الفوترة الوطني
    'D . البيانات الخاصة بالمشتري) وصف ثابت دون تغيير او إضافة(
    'مثال
    '<cac:AccountingCustomerParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingCustomerParty>
    '<cac:AccountingCustomerParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingCustomerParty>
    'بيانات المشرتي تكون من الفاتورة الأصلية ي فاتورة الإرجاع
    'حيث لا تعديل عليها ف
    'دائرة ضريبة الدخل والمبيعات
    '48 الدليل التقني للربط مع نظام الفوترة الوطني
    'E . البيانات الخاصة بتسلسل مصدر الدخل للبائع )المكلف(
    'الوصف XML Element تسلسل مصدر الدخل )النشاط( للمكلف )البائع(
    '<cac:SellerSupplierParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID>تسلسل مصدر الدخل </cbc:ID>
    '</cac:PartyIdentification>
    '</cac:Party>
    '</cac:SellerSupplierParty> مثال
    '<cac:SellerSupplierParty> <cac:Party> <cac:PartyIdentification> <cbc:ID>9932895</cbc:ID> </cac:PartyIdentification> </cac:Party> </cac:SellerSupplierParty>
    'F . سبب الارجاع
    '<cac:PaymentMeans>
    '<cbc:PaymentMeansCode listID="UN/ECE 4461">10</cbc:PaymentMeansCode> <cbc:InstructionNote>سبب الارجاع </cbc:InstructionNote>
    '</cac:PaymentMeans> الوصف XML Element يجب ادخال سبب لعملية الارجاع <cbc:InstructionNote> سبب الارجاع </cbc:InstructionNote> مثال
    '<cac:PaymentMeans> <cbc:PaymentMeansCode listID="UN/ECE 4461">10</cbc:PaymentMeansCode> <cbc:InstructionNote>Items Expire</cbc:InstructionNote> </cac:PaymentMeans>
    'دائرة ضريبة الدخل والمبيعات
    '49 الدليل التقني للربط مع نظام الفوترة الوطني
    'G . مجموع الخصم
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">مجموع الخصم </cbc:Amount>
    '</cac:AllowanceCharge> الوصف XML Element مجموع قيمة الخصم لجميع العناصر
    'المراد ارجاعها او ارجاع جزء منها
    '<cbc:Amount currencyID="JO">مجموع الخصم </cbc:Amount> مثال
    '<cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">25.00</cbc:Amount> </cac:AllowanceCharge>
    'H . مجموع قيمة الضريبة المراد ارجاعها
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">مجموع قيم ال ضيبة المراد ارجاعها من الفاتورة </cbc:TaxAmount>
    '<cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">مجموع الفاتورة المراد ارجاعها </cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">قيمة ال ضيبة المراد ارجاعها من السلعة </cbc:TaxAmount>
    '<cac:TaxCategory>
    '<cbc:ID schemeID="UN/ECE 5305" schemeAgencyID="6">S</cbc:ID> <cbc:Percent>نسبة ال ضيبة للسلعة المراد ارجاعها </cbc:Percent>
    '<cac:TaxScheme>
    '<cbc:ID schemeID="UN/ECE 5153" schemeAgencyID="6">VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal>
    '</cac:TaxTotal>
    'الوصف XML Element مجموع قيم ال ضيبة لكل السلع المراد
    'ارجاعها من الفاتورة الاصلية او ارجاع جزء
    'منها
    '<cbc:TaxAmount currencyID="JO"> مجموع قيم ال ضيبة المراد ارجاعها
    'من الفاتورة </cbc:TaxAmount> مجموع الفاتورة المراد ارجاعها قبل ال ضيبة <cbc:TaxableAmount currencyID="JO"> مجموع الفاتورة المراد
    'ارجاعها </cbc:TaxableAmount> قيمة ال ضيبة المراد ارجاعها من سلعة واحدة
    'او ارجاع جزء منها
    '<cbc:TaxAmount currencyID="JO"> قيمة ال ضيبة المراد ارجاعها من
    'السلعة </cbc:TaxAmount> نسبة ال ضيبة للسلعة المراد ارجاعها او ارجاع
    'جزء منها
    '<cbc:Percent>نسبة ال ضيبة للسلعة المراد ارجاعها </cbc:Percent>
    'دائرة ضريبة الدخل والمبيعات
    '50 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">160</cbc:TaxAmount> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">1000</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">160</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeID="UN/ECE 5305" schemeAgencyID="6">S</cbc:ID> <cbc:Percent>16.000</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeID="UN/ECE 5153" schemeAgencyID="6">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal>
    'مثال لأك رت من سلعة كل منها له نسبة ضيبة مختلفة
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">260</cbc:TaxAmount>==➔ مجموع ضيبة السلعة الأولى + الثانية
    '<cac:TaxSubtotal>==➔ خاصة بالسلعة الاولى
    '<cbc:TaxableAmount currencyID="JO">1000</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">160</cbc:TaxAmount>==➔ قيمة ال ضيبة للسلعة الاولى
    '<cac:TaxCategory> <cbc:ID schemeID="UN/ECE 5305" schemeAgencyID="6">S</cbc:ID> <cbc:Percent>16.000</cbc:Percent>==➔نسبة ال ضيبة للسلعة الاولى
    '<cac:TaxScheme> <cbc:ID schemeID="UN/ECE 5153" schemeAgencyID="6">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> <cac:TaxSubtotal>==➔ خاصة بالسلعة الثانية
    '<cbc:TaxableAmount currencyID="JO">1000</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">100</cbc:TaxAmount>==➔ قيمة ال ضيبة للسلعة الثانية
    '<cac:TaxCategory> <cbc:ID schemeID="UN/ECE 5305" schemeAgencyID="6">S</cbc:ID> <cbc:Percent>10.000</cbc:Percent>==➔ نسبة ال ضيبة للسلعة الثانية
    '<cac:TaxScheme> <cbc:ID schemeID="UN/ECE 5153" schemeAgencyID="6">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal>
    'ملاحظة
    'ي حالة ارجاع اكرت من سلعة حيث ان كل منها له نسبة صريبة مختلفة عن الأخرى يتم تكرار ال
    'ف <cac:TaxSubtotal>
    'ي المثال التا ي لى:
    'لكل سلعة كما ف
    'دائرة ضريبة الدخل والمبيعات
    '51 الدليل التقني للربط مع نظام الفوترة الوطني
    'I . المدخلات الخاصة بإجمالي فاتورة الارجاع
    '<cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">اجمالي الفاتورة قبل الخصم </cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">اجمالي الفاتورة </cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">مجموع قيمة الخصم </cbc:AllowanceTotalAmount>
    '<cbc:PrepaidAmount currencyID="JO">0</cbc:PrepaidAmount> <cbc:PayableAmount currencyID="JO">اجمالي الفاتورة </cbc:PayableAmount>
    '</cac:LegalMonetaryTotal> الوصف XML Element اجمالي الفاتورة )للجزء المراد ارجاعه( قبل الخصم <cbc:TaxExclusiveAmount currencyID="JO">
    'اجمالي الفاتورة قبل الخصم
    '</cbc:TaxExclusiveAmount>
    'اجمالي الفاتورة قبل الخصم = مجموع )السعر * الكمية( لجميع معلومات السلع و الخدمات في الفاتورة
    'اجمالي الفاتورة )للجزء المراد ارجاعه( <cbc:TaxInclusiveAmount currencyID="JO">
    'اجمالي الفاتورة
    '</cbc:TaxInclusiveAmount> اجمالي الفاتورة = )اجمالي الفاتورة قبل الخصم – مجموع قيمة الخصم + مجموع قيمة الضريبة العامة(
    'مجموع قيمة الخصم )للجزء المراد ارجاعه( <cbc:AllowanceTotalAmount currencyID="JO">
    'مجموع قيمة الخصم
    '</cbc:AllowanceTotalAmount>
    'مجموع قيمة الخصم= مجموع قيمة الخصم للسلع و الخدمات
    'اجمالي الفاتورة )للجزء المراد ارجاعه( <cbc:PayableAmount currencyID="JO">
    'اجمالي الفاتورة
    '</cbc:PayableAmount> اجمالي الفاتورة = )اجمالي الفاتورة قبل الخصم – مجموع قيمة الخصم + مجموع قيمة الضريبة العامة(
    'مثال
    '<cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">1000</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">1160</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">0.00</cbc:AllowanceTotalAmount> <cbc:PrepaidAmount currencyID="JO">0</cbc:PrepaidAmount> <cbc:PayableAmount currencyID="JO">1160</cbc:PayableAmount> </cac:LegalMonetaryTotal>
    'دائرة ضريبة الدخل والمبيعات
    '52 الدليل التقني للربط مع نظام الفوترة الوطني
    'J . المدخلات الخاصة بتفاصيل سلع الفاتورة العامة
    '<cac:InvoiceLine> <cbc:ID> رقم تسلس ي لى </cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">الكمية </cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:LineExtensionAmount>
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">قيمة ال ضيبة للسلعة أو الخدمة </cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">المبلغ الاجما ي لى للسلعة أو الخدمة شامل ال ضيبة
    '</cbc:RoundingAmount>
    '<cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو
    'الخدمة </cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">قيمة ال ضيبة للسلعة أو الخدمة
    '</cbc:TaxAmount>
    '<cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>نسبة ال ضيبة العامة على السلعة أو الخدمة </cbc:Percent>
    '<cac:TaxScheme>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal>
    '</cac:TaxTotal>
    '<cac:Item> <cbc:Name>وصف السلعة او الخدمة </cbc:Name>
    '</cac:Item>
    '<cac:Price> <cbc:PriceAmount currencyID="JO"> سعر الوحدة قبل ال ضيبة </cbc:PriceAmount>
    '<cbc:BaseQuantity unitCode="C62">1</cbc:BaseQuantity>
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO"> قيمة الخصم </cbc:Amount>
    '</cac:AllowanceCharge>
    '</cac:Price>
    '</cac:InvoiceLine>
    'دائرة ضريبة الدخل والمبيعات
    '53 الدليل التقني للربط مع نظام الفوترة الوطني
    'الوصف XML Element هو رقم تسلس ي لى خاص لكل
    ')سلعة أو خدمة(
    '<cbc:ID> رقم تسلس ي لى </cbc:ID> الكمية للسلعة أو الخدمة
    'الواحدة المراد ارجاعها
    '<cbc:InvoicedQuantity unitCode="PCE"> الكمية
    '</cbc:InvoicedQuantity> المبلغ الاجما ي لى للسلعة أو
    'الخدمة )المراد ارجاعها( =
    'سعر الوحدة * الكمية – خصم
    'السلعة أو الخدمة
    '<cbc:LineExtensionAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة </cbc:LineExtensionAmount> قيمة ال ضيبة للسلعة أو
    'الخدمة )المراد ارجاعها( =
    ')المبلغ الاجما ي لى للسلعة أو
    'الخدمة * نسبة ال ضيبة(
    '<cbc:TaxAmount currencyID="JO"> قيمة ال ضيبة للسلعة أو الخدمة
    '</cbc:TaxAmount> المبلغ الاجما ي لى للسلعة أو الخدمة شامل ال ضيبة )المراد
    'ارجاعها( =
    'المبلغ الاجما ي لى للسلعة أو الخدمة + قيمة ال ضيبة
    'للسلعة أو الخدمة
    '<cbc:RoundingAmount currencyID="JO"> المبلغ الاجما ي لى للسلعة أو الخدمة شامل ال ضيبة
    '</cbc:RoundingAmount> المبلغ الاجما ي لى للسلعة أو الخدمة )المراد ارجاعها( =
    'سعر الوحدة * الكمية – خصم السلعة أو الخدمة
    '<cbc:TaxableAmount currencyID="JO"> )سعر الوحدة *
    'الكمية( – خصم السلعة أو الخدمة </cbc:TaxableAmount> قيمة ال ضيبة للسلعة أو الخدمة )المراد ارجاعها( =
    ')المبلغ الاجما ي لى للسلعة أو الخدمة * نسبة ال ضيبة(
    '<cbc:TaxAmount currencyID="JO"> قيمة ال ضيبة للسلعة أو
    'الخدمة </cbc:TaxAmount> ي الجدول أدناه:
    'موضحة ف <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID>
    'القيمة الوصف نسبة ال ضيبة) Precent )
    'Zحال كانت السلعة او الخدمة معفية
    'ف 0
    'O
    'ف حال كانت السلعة او الخدمة خاضعة لنسبة الصفر 0
    'S حال كانت السلعة او الخدمة خاضعة لنسبة من النسب ال ضيبية ما عدا ال
    'ف 0 % 1,2,3,4,5,7,8,10,16.. نسبة ال ضيبة العامة على السلعة أو الخدمة )المراد
    'ارجاعها( وحسب النسب التالية
    '1 ,% 2 ,% 3 ,% 4 ,% 5 ,% 7 ,% 8 ,% 10 ,% 16 %
    'والصيغة تكون حسب الامثلة التالية:
    '</cbc:Percent>1<cbc:Percent> </cbc:Percent>2<cbc:Percent> <cbc:Percent>8</cbc:Percent>
    '<cbc:Percent>16</cbc:Percent><cbc:Percent> نسبة ال ضيبة العامة على السلعة أو الخدمة
    '</cbc:Percent> يتم وضع اسم السلعة او الخدمة او وصفه ا )المراد
    'ارجاعها(
    '<cbc:Name>وصف السلعة او الخدمة </cbc:Name> سعر السلعة او الخدمة قبل ال ضيبة )المراد ارجاعها( <cbc:PriceAmount currencyID="JO">
    'سعر الوحدة قبل ال ضيبة
    '</cbc:PriceAmount> يتم اضافة قيمة الخصم للسلعة أو الخدمة ان وجد
    'ي من اجما ي لى سعر السلعة
    'بالدينار الارد ن أو الخدمة )المراد
    'ارجاعها(
    '<cbc:Amount currencyID="JO"> قيمة الخصم
    '</cbc:Amount>
    'دائرة ضريبة الدخل والمبيعات
    '54 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cac:InvoiceLine>==➔ بداية )السلعة أو الخدمة( الأولى
    '<cbc:ID>1</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">33.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">64.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">4.48</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">68.48</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxAmount currencyID="JO">4.48</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>7.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name> Biscuit </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">2.00</cbc:PriceAmount> <cbc:BaseQuantity unitCode="C62">1</cbc:BaseQuantity> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine> <cac:InvoiceLine> ==➔ بداية )السلعة أو الخدمة( الثانية
    '<cbc:ID>2</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">10.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">50.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">5.00</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">55.00</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxAmount currencyID="JO">5.00</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>10.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme>
    'دائرة ضريبة الدخل والمبيعات
    '55 الدليل التقني للربط مع نظام الفوترة الوطني
    '</cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name> Choclate </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">5.00</cbc:PriceAmount> <cbc:BaseQuantity unitCode="C62">1</cbc:BaseQuantity> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">0.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'ملاحظة
    'ي المثال اعلاه
    'يمكن ارجاع أكرت من )سلعة أو خدمة( وذلك بتكرار بيانات)الخدمة أو السلعة( المراد ارجاعهما كما يظهر ف
    'دائرة ضريبة الدخل والمبيعات
    '56 الدليل التقني للربط مع نظام الفوترة الوطني
    'خامس اا: فاتورة المبيعات الخاصة
    'دائرة ضريبة الدخل والمبيعات
    '57 الدليل التقني للربط مع نظام الفوترة الوطني
    'العناصر المظللة باللون الأصفر في الأمثلة أدناه تدل على متغيرات مطلوب تعبئتها )إجبارية( من خلال نظام البائع.
    'أما العناصر المظللة باللون الأخضر تدل على متغيرات مطلوب تعبئتها )إختيارية( من خلال نظام البائع.
    'وباقي العناصر وصف ثابت بدون تغيير.
    'A . معلومات الفاتورة الأساسية
    '<cbc:ID> رقم الفاتورة </cbc:ID> <cbc:UUID>رقم متسلسل غ رت مكرر </cbc:UUID> <cbc:IssueDate>2022-09-27</cbc:IssueDate> <cbc:InvoiceTypeCode name="طريقة الدفع ">جديدة /إرجاع </cbc:InvoiceTypeCode> <cbc:Note>ملاحظة او وصف الفاتورة </cbc:Note>
    '<cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode>
    '<cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode>
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>عداد الفاتورة </cbc:UUID>
    '</cac:AdditionalDocumentReference> الوصف XML Element يتم ادخال رقم الفاتورة هنا
    '<cbc:ID> رقم الفاتورة </cbc:ID> رقم مم ر ت UUID (Universal Unique Identifier) يتم انشاؤه من قبل نظام المكلف
    'بحيث يشكل ID و UUID معا مفتاحا رئيسيا
    '( Primary Key ( لعدم تكرار الفاتورة المرسلة على
    'النظام
    '<cbc:UUID> رقم متسلسل غ رت مكرر </cbc:UUID> تاري خ الفاتورة ويجب ان يكون حسب الصيغة
    'التالية yyyy-mm-dd مثال 2022-12-31
    '<cbc:IssueDate> تاري خ الفاتورة </cbc:IssueDate> - خاصية name ي ه للدلالة على طريقة الدفع
    ')نقدي، ذمم(
    'ي هذا المثال تخص فوات رت ال ضيبة
    'الكودات الواردة ف
    'الخاصة فقط.
    'الرقم 388 للدلالة على انها فاتورة جديدة والرقم
    '381 انها فاتورة ارجاع ي الجدول أدناه
    'كما ف
    '<cbc:InvoiceTypeCode name=" طريقة الدفع "> جديدة /إرجاع
    '</cbc:InvoiceTypeCode>
    'إنشاء فاتورة جديدة نقدية <cbc:InvoiceTypeCode name="013">388</cbc:InvoiceTypeCode> انشاء فاتورة ذمم <cbc:InvoiceTypeCode name="023">388</cbc:InvoiceTypeCode>
    'تستخدم لإضافة اي ملاحظات او وصف
    'ي توثيقها.
    'للفاتورة او اي بيانات برغب البائع ف
    '<cbc:Note> ملاحظة او وصف الفاتورة </cbc:Note>
    'عداد للفاتورة يتم انشاؤه من قبل المكلف
    ')عداد يتم إنشاؤه من قبل المكلف للفوات رت الإلك رتونية
    'يبدأ بشكل تسلس ل من 1 الى مالانهاية حسب التعريف
    'العال م (
    'ملاحظة:
    'يرغب بها
    'يمكن للمكلف انشاء تسلسل بالطريقة ال ر ن
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>عداد الفاتورة </cbc:UUID>
    '</cac:AdditionalDocumentReference>
    'دائرة ضريبة الدخل والمبيعات
    '58 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cbc:ID>EIN00090</cbc:ID> <cbc:UUID>0043e15e-740b-4e1b-889d-504afdb1d1d</cbc:UUID> <cbc:IssueDate>2022-09-27</cbc:IssueDate> <cbc:InvoiceTypeCode name="013">388</cbc:InvoiceTypeCode> <cbc:Note> ملاحظات 22</cbc:Note> <cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode> <cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:AdditionalDocumentReference> <cbc:ID>ICV</cbc:ID> <cbc:UUID>1</cbc:UUID> </cac:AdditionalDocumentReference>
    'دائرة ضريبة الدخل والمبيعات
    '59 الدليل التقني للربط مع نظام الفوترة الوطني
    'B . البيانات الخاصة بالبائع )المكلف(
    '<cac:AccountingSupplierParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme> <cbc:CompanyID>الرقم الضريبي للبائع </cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName>اسم البائع </cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingSupplierParty> الوصف XML Element الرقم ال ضيى ي ن الخاص بالمكلف )البائع(
    '<cbc:CompanyID> الرقم ال ضيى ي ن
    'للبائع </cbc:CompanyID> ي صريبة الدخل
    'اسم البائع كما هو مسجل ف
    'والمبيعات
    '<cbc:RegistrationName> اسم
    'البائع </cbc:RegistrationName> مثال
    '<cac:AccountingSupplierParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>12345678</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName> ال ر شكة الصناعية لانتاج الدخان </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingSupplierParty>
    'دائرة ضريبة الدخل والمبيعات
    '60 الدليل التقني للربط مع نظام الفوترة الوطني
    'C . البيانات الخاصة بالمشتري
    '<cac:AccountingCustomerParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID schemeID="النوع ">الرقم </cbc:ID>
    '</cac:PartyIdentification>
    '<cac:PostalAddress> <cbc:PostalZone>الرمز ال ىتيدي </cbc:PostalZone> <cbc:CountrySubentityCode>المدينة </cbc:CountrySubentityCode>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme>
    '<cbc:CompanyID>1</cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName>اسم المشرتي </cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '<cac:AccountingContact> <cbc:Telephone>رقم الهاتف </cbc:Telephone>
    '</cac:AccountingContact>
    '</cac:AccountingCustomerParty> الوصف XML Element يتم ادخال احدى الخيارات الخاصة ببيانات
    'المشرتي وعلى ان تكون فقط أرقام وحسب
    'الجدول التا ي لى
    '<cbc:ID
    'schemeID="النوع ">الرقم </cbc:ID> النوع الرقم
    'NINي للمشرتي
    'الرقم الوط ن
    'PN ي
    'الارد ن الرقم الشخ ي ص لغ رت
    'TN الرقم ال ضيى ي ن للمشرتي
    'ملاحظة
    'ي حال كانت الفاتورة )ذمم( او كانت قيمة الفاتورة )النقدية( أكرت من ع رسرة الاف دينار
    'اسم المشرتي اجباري ف
    'دائرة ضريبة الدخل والمبيعات
    '61 الدليل التقني للربط مع نظام الفوترة الوطني
    'الوصف XML Element
    'الرمز ال ىتيدي للمشرتي
    '<cbc:PostalZone> الرمز
    'ال رتيدي </cbc:PostalZone> رمز المحافظة الخاصة بالمشرتي ويتم
    'استبدالها حسب الجدول التا ي لى
    'JO-BA البلقاء
    'JO-MN معان
    'JO-MD مادبا
    'JO-MA المفرق
    'JO-KA الكرك
    'JO-JA جرش
    'JO-IR إربد
    'JO-AZ الزرقاء
    'JO-AT الطفيلة
    'JO-AQ العقبة
    'JO-AM عمان
    'JO-AJ عجلون
    '<cbc:CountrySubentityCode> المدينة
    '</cbc:CountrySubentityCode>
    'اسم المشرتي
    '<cbc:RegistrationName> اسم
    'المشرتي </cbc:RegistrationName> رقم هاتف المشرتي
    '<cbc:Telephone> رقم هاتف
    'المشرتي </cbc:Telephone>
    'دائرة ضريبة الدخل والمبيعات
    '62 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cac:AccountingCustomerParty> <cac:Party> <cac:PartyIdentification> <cbc:ID schemeID="TN">33445544</cbc:ID> </cac:PartyIdentification> <cac:PostalAddress> <cbc:PostalZone>33554</cbc:PostalZone> <cbc:CountrySubentityCode>JO-AZ</cbc:CountrySubentityCode> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>33445544</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName> احم د محمد </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> <cac:AccountingContact> <cbc:Telephone>324323434</cbc:Telephone> </cac:AccountingContact> </cac:AccountingCustomerParty>
    'D . البيانات الخاصة بتسلسل مصدر الدخل للبائع )المكلف(
    'الوصف XML Element تسلسل مصدر الدخل )النشاط( للمكلف
    ')البائع(
    '<cac:SellerSupplierParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID>تسلسل مصدر الدخل </cbc:ID>
    '</cac:PartyIdentification>
    '</cac:Party>
    '</cac:SellerSupplierParty> مثال
    '<cac:SellerSupplierParty> <cac:Party> <cac:PartyIdentification> <cbc:ID>9932895</cbc:ID> </cac:PartyIdentification> </cac:Party> </cac:SellerSupplierParty>
    'دائرة ضريبة الدخل والمبيعات
    '63 الدليل التقني للربط مع نظام الفوترة الوطني
    'E . المدخلات الخاصة بإجمالي الفاتورة الخاصة
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">مجموع قيمة الخصم دينار اردني </cbc:Amount>
    '</cac:AllowanceCharge>
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">مجموع قيمة الضريبة العامة </cbc:TaxAmount>
    '</cac:TaxTotal>
    '<cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">اجمالي الفاتورة قبل الخصم </cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">اجمالي الفاتورة </cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">مجموع قيمة الخصم </cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">اجمالي الفاتورة </cbc:PayableAmount>
    '</cac:LegalMonetaryTotal> الوصف XML Element مجموع قيمة خصم السلع حيث ان النظام لا يقبل
    'الخصم على الفاتورة بشكل عام
    '<cbc:Amount currencyID="JO">
    'مجموع قيمة الخصم دينار اردني
    '</cbc:Amount> ملاحظة: في حال كان نظام المكلف يحسب الخصم على اجمالي الفاتورة يجب ان يتم توزيع الخصم على السلع و الخدمات قبل ترحيل
    'البيانات الى نظام الفوترة.
    'مجموع قيمة الضريبة العامة
    '= مجموع))المبلغ الاجمالي بعد الخصم + قيمة
    'الضريبة الخاصة( * نسبة الضريبة العامة(
    '<cbc:TaxAmount currencyID="JO">
    'مجموع قيمة الضريبة العامة
    '</cbc:TaxAmount> اجمالي الفاتورة قبل الخصم <cbc:TaxExclusiveAmount currencyID="JO">
    'اجمالي الفاتورة قبل الخصم
    '</cbc:TaxExclusiveAmount>
    'اجمالي الفاتورة قبل الخصم = مجموع )السعر * الكمية( لجميع معلومات السلع و الخدمات في الفاتورة
    'اجمالي الفاتورة
    '<cbc:TaxInclusiveAmount currencyID="JO">
    'اجمالي الفاتورة
    '</cbc:TaxInclusiveAmount> اجمالي الفاتورة = )اجمالي الفاتورة قبل الخصم – مجموع قيمة الخصم + مجموع الضريبة الخاصة+ مجموع قيمة الضريبة العامة(
    'مجموع قيمة الخصم
    '<cbc:AllowanceTotalAmount currencyID="JO">
    'مجموع قيمة الخصم
    '</cbc:AllowanceTotalAmount>
    'مجموع قيمة الخصم= مجموع قيمة الخصم للسلع و الخدمات
    'اجمالي الفاتورة
    '<cbc:PayableAmount currencyID="JO">
    'اجمالي الفاتورة
    '</cbc:PayableAmount> اجمالي الفاتورة = )اجمالي الفاتورة قبل الخصم – مجموع قيمة الخصم + مجموع الضريبة الخاصة + مجموع قيمة الضريبة
    'العامة(
    'دائرة ضريبة الدخل والمبيعات
    '64 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">144.48</cbc:TaxAmount> </cac:TaxTotal> <cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">1800.00</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">1950.48</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">2.00</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">1950.48</cbc:PayableAmount> </cac:LegalMonetaryTotal>
    'دائرة ضريبة الدخل والمبيعات
    '65 الدليل التقني للربط مع نظام الفوترة الوطني
    'F . المدخلات الخاصة بتفاصيل سلع الفاتورة الخاصة
    '<cac:InvoiceLine> <cbc:ID> رقم تسلس ي لى </cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">الكمية </cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:LineExtensionAmount>
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">قيمة ال ضيبة العامة للسلعة أو الخدمة </cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">المبلغ الاجما ي لى للسلعة أو الخدمة شامل ال ضيبةالعامة والخاصة
    '</cbc:RoundingAmount>
    '<cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">قيمة ال ضيبة الخاصة للسلعة أو الخدمة </cbc:TaxAmount>
    '<cac:TaxCategory>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID>
    '<cac:TaxScheme>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">OTH</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">قيمة ال ضيبة العامة للسلعة أو الخدمة </cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>نسبة الضريبة العامة </cbc:Percent>
    '<cac:TaxScheme>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal>
    '</cac:TaxTotal> <cac:Item> <cbc:Name>اسم السلعة او الخدمة </cbc:Name>
    '</cac:Item>
    '<cac:Price> <cbc:PriceAmount currencyID="JO">سعر الوحدة قبل الضريبة </cbc:PriceAmount>
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">قيمة الخصم </cbc:Amount>
    '</cac:AllowanceCharge>
    '</cac:Price>
    '</cac:InvoiceLine>
    '</Invoice>
    'دائرة ضريبة الدخل والمبيعات
    '66 الدليل التقني للربط مع نظام الفوترة الوطني
    'الوصف XML Element هو رقم تسلس ي لى خاص لكل )سلعة أو خدمة( <cbc:ID> رقم تسلس ي لى </cbc:ID> الكمية للسلعة أو الخدمة الواحدة <cbc:InvoicedQuantity unitCode="PCE">
    'الكمية
    '</cbc:InvoicedQuantity> المبلغ الاجما ي لى للسلعة أو الخدمة =سعر الوحدة * الكمية – خصم
    'السلعة أو الخدمة
    '<cbc:LineExtensionAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:LineExtensionAmount> قيمة ال ضيبة العامة للسلعة أو الخدمة = )المبلغ الاجما ي لى للسلعة أو
    'الخدمة + ال ضيبة الخاصة( * نسبة ال ضيبةالعامة
    '<cbc:TaxAmount currencyID="JO"> قيمة ال ضيبة العامة للسلعة أو الخدمة
    '</cbc:TaxAmount> المبلغ الاجما ي لى للسلعة أو الخدمة شامل ال ضيبة= المبلغ الاجما ي لى
    'للسلعة أو الخدمة + قيمة ال ضيبة الخاصة للسلعة أو الخدمة + قيمة
    'ال ضيبة العامة للسلعة او الخدمة
    '<cbc:RoundingAmount currencyID="JO"> المبلغ الاجما ي لى للسلعة أو الخدمة شامل ال ضيبة
    '</cbc:RoundingAmount> المبلغ الاجما ي لى للسلعة أو الخدمة =سعر الوحدة * الكمية – خصم
    'السلعة أو الخدمة
    '<cbc:TaxableAmount currencyID="JO"> )سعر الوحدة * الكمية(
    '– خصم السلعة أو الخدمة </cbc:TaxableAmount> قيمة ال ضيبة الخاصة للسلعة او الخدمة <cbc:TaxAmount currencyID="JO""> قيمة ال ضيبة الخاصة
    'للسلعة أو الخدمة </cbc:TaxAmount> المبلغ الاجما ي لى للسلعة أو الخدمة =سعر الوحدة * الكمية – خصم
    'السلعة أو الخدمة
    '<cbc:TaxableAmount currencyID="JO"> )سعر الوحدة * الكمية(
    '– خصم السلعة أو الخدمة </cbc:TaxableAmount> قيمة ال ضيبة العامة للسلعة أو الخدمة <cbc:TaxAmount currencyID="JO"> قيمة ال ضيبة العامة للسلعة
    'أو الخدمة </cbc:TaxAmount> ي الجدول أدناه:
    'موضحة ف <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID>
    'القيمة الوصف نسبة ال ضيبة) Precent )
    'Zحال كانت السلعة او الخدمة معفية
    'ف 0
    'O حال كانت السلعة او الخدمة خاضعة لنسبة الصفر
    'ف 0
    'S حال كانت السلعة او الخدمة خاضعة لنسبة من النسب ال ضيبية ما عدا ال
    'ف 0 % 1,2,3,4,5,7,8,10,16.. نسبة ال ضيبة العامة على السلعة أو الخدمة وحسب النسب التالية
    '1 ,% 2 ,% 3 ,% 4 ,% 5 ,% 7 ,% 8 ,% 10 ,% 16 %
    'والصيغة تكون حسب الامثلة التالية:
    '<cbc:Percent>1</cbc:Percent>
    '<cbc:Percent>4</cbc:Percent>
    '</cbc:Percent>8<cbc:Percent> </cbc:Percent>16<cbc:Percent><cbc:Percent> نسبة ال ضيبة العامة على السلعة أو الخدمة
    '</cbc:Percent> يتم وضع اسم السلعة او الخدمة او وصفها <cbc:Name> وصف السلعة او الخدمة </cbc:Name> سعر السلعة او الخدمة قبل ال ضيبة <cbc:PriceAmount currencyID="JO">
    'سعر الوحدة قبل ال ضيبة
    '</cbc:PriceAmount> يتم اضافة قيمة الخصم للسلعة أو الخدمة ي
    'ان وجد بالدينار الارد ن
    'من اجما ي لى سعر السلعة أو الخدمة
    '<cbc:Amount currencyID="JO"> قيمة الخصم
    '</cbc:Amount>
    'دائرة ضريبة الدخل والمبيعات
    '67 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cac:InvoiceLine>==➔ بداية )السلعة أو الخدمة( الأولى
    '<cbc:ID>1</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">10.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">495.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">555.500</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495.000</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">10.00</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cac:TaxScheme> <cbc:ID schemeAgencyID=""6"" schemeID=""UN/ECE 5153"">OTH</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495.00</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>10.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name>Malboro</cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">50.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">5.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'دائرة ضريبة الدخل والمبيعات
    '68 الدليل التقني للربط مع نظام الفوترة الوطني
    '<cac:InvoiceLine> ==➔ بداية )السلعة أو الخدمة( الثانية
    '<cbc:ID>2</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">10.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">495.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">555.500</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">10.00</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">OTH</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495.00</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>10.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name>Malboro2 </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">50.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">5.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'ي المثال اعلاه
    'يمكن إضافة أكرت من )سلعة أو خدمة( وذلك بتكرار بيانات) الخدمة أو السلعة( المراد إضافتها كما يظهر ف
    'دائرة ضريبة الدخل والمبيعات
    '69 الدليل التقني للربط مع نظام الفوترة الوطني
    'سادساا: فاتورة إرجاع المبيعات
    'الخاصة
    'دائرة ضريبة الدخل والمبيعات
    '70 الدليل التقني للربط مع نظام الفوترة الوطني
    'العناصر المظللة باللون الأصفر في الأمثلة أدناه تدل على متغيرات مطلوب تعبئتها )إجبارية( من خلال نظام البائع.
    'أما العناصر المظللة باللون الأخضر تدل على متغيرات مطلوب تعبئتها )إختيارية( من خلال نظام البائع.
    'وباقي العناصر وصف ثابت بدون تغيير.
    'A . معلومات الفاتورة الأساسية
    '<cbc:ID>رقم فاتورة الارجاع </cbc:ID> <cbc:UUID> رقم متسلسل لفاتورة الارجاع </cbc:UUID> <cbc:IssueDate>تاريخ فاتورة الارجاع </cbc:IssueDate> <cbc:InvoiceTypeCode name="طريقة الدفع ">381</cbc:InvoiceTypeCode>
    '<cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode>
    '<cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode>
    '<cac:BillingReference>
    '<cac:InvoiceDocumentReference> <cbc:ID>رقم الفاتورة الاصلية المراد الارجاع منها </cbc:ID> <cbc:UUID>الرقم المتسلسل للفاتورة الاصلية المراد الارجاع منها </cbc:UUID> <cbc:DocumentDescription>اجمالي الفاتورة الاصلية المراد الارجاع منها </cbc:DocumentDescription>
    '</cac:InvoiceDocumentReference>
    '</cac:BillingReference>
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>عداد الفاتورة </cbc:UUID>
    '</cac:AdditionalDocumentReference> الوصف XML Element يتم ادخال رقم الفاتورة هنا <cbc:ID> رقم فاتورة الارجاع </cbc:ID> رقم مم ر ت UUID (Universal Unique Identifier) يتم انشاؤه
    'من قبل نظام المكلف بحيث يشكل ID و UUID معا مفتاحا رئيسيا
    '( Primary Key ( لعدم تكرار الفاتورة المرسلة على النظام
    '<cbc:UUID> رقم متسلسل لفاتورة الارجاع </cbc:UUID> تاري خ الفاتورة ويجب ان يكون حسب الصيغة التالية yyyy-mm-dd مثال 2022-12-31<cbc:IssueDate>تاري خ فاتو رة الارجاع </cbc:IssueDate> - خاصية name ي ه للدلالة على طريقة الدفع )نقدي، ذمم(
    'ي هذا المثال تخص فوات رت ال ضيبة
    'الكودات الواردة ف الخاصة فقط.
    'الرقم 381 يدل على انها فاتورة ارجاع ي الجدول أدناه
    'كما ف
    '<cbc:InvoiceTypeCode name="طريقة الدفع "> 381
    '</cbc:InvoiceTypeCode>
    'انشاء فاتورة ارجاع نقدي <cbc:InvoiceTypeCode name="013">381</cbc:InvoiceTypeCode> انشاء فاتورة ارجاع ذمم <cbc:InvoiceTypeCode name="023">381</cbc:InvoiceTypeCode>
    'يتم ادخال رقم الفاتورة هنا <cbc:ID> رقم فاتورة الارجاع </cbc:ID> رقم مم ر ت UUID (Universal Unique Identifier) يتم انشاؤه
    'من قبل نظام المكلف بحيث يشكل ID و UUID معا مفتاحا رئيسيا
    '( Primary Key ( لعدم تكرار الفاتورة المرسلة على النظام
    '<cbc:UUID> رقم متسلسل لفاتورة الارجاع </cbc:UUID>
    'دائرة ضريبة الدخل والمبيعات
    '71 الدليل التقني للربط مع نظام الفوترة الوطني
    'B . معلومات الفاتورة المراد الارجاع منها
    '<cac:BillingReference>
    '<cac:InvoiceDocumentReference> <cbc:ID>رقم الفاتورة الاصلية المراد الارجاع منها </cbc:ID> <cbc:UUID>الرقم المتسلسل للفاتورة الاصلية المراد الارجاع منها </cbc:UUID> <cbc:DocumentDescription>اجما ي لى الفاتورة الاصلية المراد الارجاع منها </cbc:DocumentDescription>
    '</cac:InvoiceDocumentReference>
    '</cac:BillingReference> الوصف XML Element رقم الفاتورة الاصلية المراد الارجاع منها <cbc:ID> رقم الفاتورة الاصلية المراد الارجاع منها </cbc:ID> الرقم المتسلسل للفاتورة الاصلية المراد الارجاع منها <cbc:UUID> الرقم المتسلسل للفاتورة الاصلية المراد الارجاع منها </cbc:UUID>
    'اجما ي لى الفاتورة الاصلية المراد الارجاع منها <cbc:DocumentDescription> اجما ي لى الفاتورة الاصلية المراد الارجاع
    'منها </cbc:DocumentDescription> عداد للفاتورة يتم انشاؤه من قبل المكلف
    ')عداد يتم إنشاؤه من قبل المكلف للفوات رت الإلك رتونية يبدأ بشكل
    'تسلس ل من 1 الى مالانهاية حسب التعريف العال م (
    'ملاحظة:
    'يرغب بها
    'يمكن للمكلف انشاء تسلسل بالطريقة ال ر ن
    '<cac:AdditionalDocumentReference>
    '<cbc:ID>ICV</cbc:ID> <cbc:UUID>عداد الفاتورة </cbc:UUID>
    '</cac:AdditionalDocumentReference>
    'مثال
    '<cbc:ID>EIN0002</cbc:ID> <cbc:UUID>8055b137-a128-46d6-9421-8c2a6de57465</cbc:UUID> <cbc:IssueDate>2023-11-20</cbc:IssueDate> <cbc:InvoiceTypeCode name="013">381</cbc:InvoiceTypeCode> <cbc:DocumentCurrencyCode>JOD</cbc:DocumentCurrencyCode> <cbc:TaxCurrencyCode>JOD</cbc:TaxCurrencyCode> <cac:BillingReference> <cac:InvoiceDocumentReference> <cbc:ID>EIN0001</cbc:ID> <cbc:UUID>0043e15e-740b-4e1b-889d-8504afdb1d1d2</cbc:UUID> <cbc:DocumentDescription>68.48</cbc:DocumentDescription> </cac:InvoiceDocumentReference> </cac:BillingReference> <cac:AdditionalDocumentReference> <cbc:ID>ICV</cbc:ID> <cbc:UUID>2</cbc:UUID> </cac:AdditionalDocumentReference>
    'دائرة ضريبة الدخل والمبيعات
    '72 الدليل التقني للربط مع نظام الفوترة الوطني
    'C . البيانات الخاصة بالبائع )المكلف(
    '<cac:AccountingSupplierParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme> <cbc:CompanyID>الرقم الضريبي للبائع </cbc:CompanyID>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity> <cbc:RegistrationName>اسم البائع </cbc:RegistrationName>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingSupplierParty> الوصف XML Element الرقم ال ضيى ي ن الخاص بالمكلف )البائع( <cbc:CompanyID> الرقم ال ضيى ي ن للبائع </cbc:CompanyID> ي صريبة الدخل
    'اسم البائع كما هو مسجل ف
    'والمبيعات
    '<cbc:RegistrationName>اسم البائع </cbc:RegistrationName> مثال
    '<cac:AccountingSupplierParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cbc:CompanyID>12345678</cbc:CompanyID> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> <cbc:RegistrationName> ال ر شكة الصناعية لانتاج الدخان </cbc:RegistrationName> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingSupplierParty>
    'دائرة ضريبة الدخل والمبيعات
    '73 الدليل التقني للربط مع نظام الفوترة الوطني
    'D . البيانات الخاصة بالمشتري) وصف ثابت دون تغيير او إضافة(
    'مثال
    '<cac:AccountingCustomerParty> <cac:Party> <cac:PostalAddress> <cac:Country> <cbc:IdentificationCode>JO</cbc:IdentificationCode> </cac:Country> </cac:PostalAddress> <cac:PartyTaxScheme> <cac:TaxScheme> <cbc:ID>VAT</cbc:ID> </cac:TaxScheme> </cac:PartyTaxScheme> <cac:PartyLegalEntity> </cac:PartyLegalEntity> </cac:Party> </cac:AccountingCustomerParty>
    '<cac:AccountingCustomerParty>
    '<cac:Party>
    '<cac:PostalAddress>
    '<cac:Country>
    '<cbc:IdentificationCode>JO</cbc:IdentificationCode>
    '</cac:Country>
    '</cac:PostalAddress>
    '<cac:PartyTaxScheme>
    '<cac:TaxScheme>
    '<cbc:ID>VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:PartyTaxScheme>
    '<cac:PartyLegalEntity>
    '</cac:PartyLegalEntity>
    '</cac:Party>
    '</cac:AccountingCustomerParty>
    'بيانات المشرتي تكون من الفاتورة ي فاتورة الإرجاع
    'الأصلية حيث لا تعديل عليها ف
    'دائرة ضريبة الدخل والمبيعات
    '74 الدليل التقني للربط مع نظام الفوترة الوطني
    'E . البيانات الخاصة بتسلسل مصدر الدخل للبائع )المكلف(
    'الوصف XML Element تسلسل مصدر الدخل )النشاط( للمكلف )البائع(
    '<cac:SellerSupplierParty>
    '<cac:Party>
    '<cac:PartyIdentification> <cbc:ID>تسلسل مصدر الدخل </cbc:ID>
    '</cac:PartyIdentification>
    '</cac:Party>
    '</cac:SellerSupplierParty> مثال
    '<cac:SellerSupplierParty> <cac:Party> <cac:PartyIdentification> <cbc:ID>9932895</cbc:ID> </cac:PartyIdentification> </cac:Party> </cac:SellerSupplierParty>
    'F . سبب الارجاع
    '<cac:PaymentMeans>
    '<cbc:PaymentMeansCode listID="UN/ECE 4461">10</cbc:PaymentMeansCode> <cbc:InstructionNote>سبب الارجاع </cbc:InstructionNote>
    '</cac:PaymentMeans> الوصف XML Element يجب ادخال سبب لعملية الارجاع <cbc:InstructionNote> سبب الارجاع </cbc:InstructionNote> مثال
    '<cac:PaymentMeans> <cbc:PaymentMeansCode listID="UN/ECE 4461">10</cbc:PaymentMeansCode> <cbc:InstructionNote>Items Expire</cbc:InstructionNote> </cac:PaymentMeans>
    'دائرة ضريبة الدخل والمبيعات
    '75 الدليل التقني للربط مع نظام الفوترة الوطني
    'G . المدخلات الخاصة بإجمالي الفاتورة الخاصة
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">مجموع قيمة الخصم دينار اردني </cbc:Amount>
    '</cac:AllowanceCharge>
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">مجموع قيمة الضريبة العامة </cbc:TaxAmount>
    '</cac:TaxTotal>
    '<cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">اجمالي الفاتورة قبل الخصم </cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">اجمالي الفاتورة </cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">مجموع قيمة الخصم </cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">اجمالي الفاتورة </cbc:PayableAmount>
    '</cac:LegalMonetaryTotal> الوصف XML Element مجموع قيمة خصم السلع )المراد ارجاعها( حيث ان النظام لا
    'يقبل الخصم على الفاتورة بشكل عام
    '<cbc:Amount currencyID="JO"> مجموع قيمة الخصم دينار اردني
    '</cbc:Amount> ملاحظة: في حال كان نظام المكلف يحسب الخصم على اجمالي الفاتورة يجب ان يتم توزيع الخصم على السلع و الخدمات قبل
    'ترحيل البيانات الى نظام الفوترة.
    'مجموع قيمة الضريبة العامة )المراد ارجاعها(
    '= مجموع )المبلغ الاجمالي بعد الخصم + قيمة الضريبة
    'الخاصة( * نسبة الضريبة العامة
    '<cbc:TaxAmount currencyID="JO"> مجموع قيمة الضريبة العامة
    '</cbc:TaxAmount> اجمالي الفاتورة قبل الخصم )المراد ارجاعها( <cbc:TaxExclusiveAmount currencyID="JO">
    'اجمالي الفاتورة قبل الخصم
    '</cbc:TaxExclusiveAmount>
    'اجمالي الفاتورة قبل الخصم = مجموع )السعر * الكمية( لجميع معلومات السلع و الخدمات في الفاتورة
    'اجمالي الفاتورة )المراد ارجاعها( <cbc:TaxInclusiveAmount currencyID="JO">
    'اجمالي الفاتورة
    '</cbc:TaxInclusiveAmount> اجمالي الفاتورة = )اجمالي الفاتورة قبل الخصم – مجموع قيمة الخصم + مجموع الضريبة الخاصة+ مجموع قيمة الضريبة العامة(
    'مجموع قيمة الخصم )المراد ارجاعه( <cbc:AllowanceTotalAmount currencyID="JO">
    'مجموع قيمة الخصم
    '</cbc:AllowanceTotalAmount>
    'مجموع قيمة الخصم= مجموع قيمة الخصم للسلع و الخدمات
    'اجمالي الفاتورة )المراد ارجاعها( <cbc:PayableAmount currencyID="JO">
    'اجمالي الفاتورة
    '</cbc:PayableAmount> اجمالي الفاتورة = )اجمالي الفاتورة قبل الخصم – مجموع قيمة الخصم + مجموع الضريبة الخاصة + مجموع قيمة الضريبة
    'العامة(
    'دائرة ضريبة الدخل والمبيعات
    '76 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>discount</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">2.00</cbc:Amount> </cac:AllowanceCharge> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">144.48</cbc:TaxAmount> </cac:TaxTotal> <cac:LegalMonetaryTotal> <cbc:TaxExclusiveAmount currencyID="JO">1800.00</cbc:TaxExclusiveAmount> <cbc:TaxInclusiveAmount currencyID="JO">1950.48</cbc:TaxInclusiveAmount> <cbc:AllowanceTotalAmount currencyID="JO">2.00</cbc:AllowanceTotalAmount> <cbc:PayableAmount currencyID="JO">1950.48</cbc:PayableAmount> </cac:LegalMonetaryTotal>
    'دائرة ضريبة الدخل والمبيعات
    '77 الدليل التقني للربط مع نظام الفوترة الوطني
    'H . المدخلات الخاصة بتفاصيل سلع الفاتورة الخاصة
    '<cac:InvoiceLine> <cbc:ID> رقم تسلس ي لى </cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">الكمية </cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:LineExtensionAmount>
    '<cac:TaxTotal> <cbc:TaxAmount currencyID="JO">قيمة ال ضيبة العامة للسلعة أو الخدمة </cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">المبلغ الاجما ي لى للسلعة أو الخدمة شامل ال ضيبةالعامة والخاصة
    '</cbc:RoundingAmount>
    '<cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">قيمة ال ضيبة الخاصة للسلعة أو الخدمة </cbc:TaxAmount>
    '<cac:TaxCategory>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID>
    '<cac:TaxScheme>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">OTH</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">قيمة ال ضيبة العامة للسلعة أو الخدمة </cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>نسبة الضريبة العامة </cbc:Percent>
    '<cac:TaxScheme>
    '<cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID>
    '</cac:TaxScheme>
    '</cac:TaxCategory>
    '</cac:TaxSubtotal>
    '</cac:TaxTotal> <cac:Item> <cbc:Name>اسم السلعة او الخدمة </cbc:Name>
    '</cac:Item>
    '<cac:Price> <cbc:PriceAmount currencyID="JO">سعر الوحدة قبل الضريبة </cbc:PriceAmount>
    '<cac:AllowanceCharge>
    '<cbc:ChargeIndicator>false</cbc:ChargeIndicator>
    '<cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">قيمة الخصم </cbc:Amount>
    '</cac:AllowanceCharge>
    '</cac:Price>
    '</cac:InvoiceLine>
    '</Invoice>
    'دائرة ضريبة الدخل والمبيعات
    '78 الدليل التقني للربط مع نظام الفوترة الوطني
    'الوصف XML Element هو رقم تسلس ي لى خاص لكل )سلعة أو خدمة( <cbc:ID> رقم تسلس ي لى </cbc:ID> الكمية للسلعة أو الخدمة الواحدة )المراد ارجاعها( <cbc:InvoicedQuantity unitCode="PCE">
    'الكمية
    '</cbc:InvoicedQuantity> المبلغ الاجما ي لى للسلعة أو الخدمة =سعر الوحدة * الكمية – خصم
    'السلعة أو الخدمة
    '<cbc:LineExtensionAmount currencyID="JO"> )سعر الوحدة * الكمية( – خصم السلعة أو الخدمة
    '</cbc:LineExtensionAmount> قيمة ال ضيبة العامة للسلعة أو الخدمة = )المبلغ الاجما ي لى للسلعة أو
    'الخدمة + ال ضيبة الخاصة( * نسبة ال ضيبةالعامة
    '<cbc:TaxAmount currencyID="JO"> قيمة ال ضيبة العامة للسلعة أو الخدمة
    '</cbc:TaxAmount> المبلغ الاجما ي لى للسلعة أو الخدمة شامل ال ضيبة= المبلغ الاجما ي لى
    'للسلعة أو الخدمة + قيمة ال ضيبة الخاصة للسلعة أو الخدمة + قيمة
    'ال ضيبة العامة للسلعة او الخدمة
    '<cbc:RoundingAmount currencyID="JO"> المبلغ الاجما ي لى للسلعة أو الخدمة شامل ال ضيبة
    '</cbc:RoundingAmount> المبلغ الاجما ي لى للسلعة أو الخدمة =سعر الوحدة * الكمية – خصم
    'السلعة أو الخدمة
    '<cbc:TaxableAmount currencyID="JO"> )سعر الوحدة * الكمية(
    '– خصم السلعة أو الخدمة </cbc:TaxableAmount> قيمة ال ضيبة الخاصة للسلعة او الخدمة <cbc:TaxAmount currencyID="JO""> قيمة ال ضيبة الخاصة
    'للسلعة أو الخدمة </cbc:TaxAmount> المبلغ الاجما ي لى للسلعة أو الخدمة =سعر الوحدة * الكمية – خصم
    'السلعة أو الخدمة
    '<cbc:TaxableAmount currencyID="JO"> )سعر الوحدة * الكمية(
    '– خصم السلعة أو الخدمة </cbc:TaxableAmount> قيمة ال ضيبة العامة للسلعة أو الخدمة <cbc:TaxAmount currencyID="JO"> قيمة ال ضيبة العامة للسلعة
    'أو الخدمة </cbc:TaxAmount> ي الجدول أدناه:
    'موضحة ف <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID>
    'القيمة الوصف نسبة ال ضيبة) Precent )
    'Zحال كانت السلعة او الخدمة معفية
    'ف 0
    'O حال كانت السلعة او الخدمة خاضعة لنسبة الصفر
    'ف 0
    'S حال كانت السلعة او الخدمة خاضعة لنسبة من النسب ال ضيبية ما عدا ال
    'ف 0 % 1,2,3,4,5,7,8,10,16.. نسبة ال ضيبة العامة على السلعة أو الخدمة وحسب النسب التالية
    '1 ,% 2 ,% 3 ,% 4 ,% 5 ,% 7 ,% 8 ,% 10 ,% 16 %
    'والصيغة تكون حسب الامثلة التالية:
    '<cbc:Percent>1</cbc:Percent>
    '<cbc:Percent>4</cbc:Percent>
    '</cbc:Percent>8<cbc:Percent> </cbc:Percent>16<cbc:Percent><cbc:Percent> نسبة ال ضيبة العامة على السلعة أو الخدمة
    '</cbc:Percent> يتم وضع اسم السلعة او الخدمة او وصفها <cbc:Name> وصف السلعة او الخدمة </cbc:Name> سعر السلعة او الخدمة قبل ال ضيبة <cbc:PriceAmount currencyID="JO">
    'سعر الوحدة قبل ال ضيبة
    '</cbc:PriceAmount> يتم اضافة قيمة الخصم للسلعة أو الخدمة ي
    'ان وجد بالدينار الارد ن
    'من اجما ي لى سعر السلعة أو الخدمة
    '<cbc:Amount currencyID="JO"> قيمة الخصم
    '</cbc:Amount>
    'دائرة ضريبة الدخل والمبيعات
    '79 الدليل التقني للربط مع نظام الفوترة الوطني
    'مثال
    '<cac:InvoiceLine>==➔ بداية )السلعة أو الخدمة( الأولى
    '<cbc:ID>1</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">10.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">495.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">555.500</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495.000</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">10.00</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cac:TaxScheme> <cbc:ID schemeAgencyID=""6"" schemeID=""UN/ECE 5153"">OTH</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495.00</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>10.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name>Malboro</cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">50.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">5.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'دائرة ضريبة الدخل والمبيعات
    '80 الدليل التقني للربط مع نظام الفوترة الوطني
    '<cac:InvoiceLine> ==➔ بداية )السلعة أو الخدمة( الثانية
    '<cbc:ID>2</cbc:ID> <cbc:InvoicedQuantity unitCode="PCE">10.00</cbc:InvoicedQuantity> <cbc:LineExtensionAmount currencyID="JO">495.00</cbc:LineExtensionAmount> <cac:TaxTotal> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cbc:RoundingAmount currencyID="JO">555.500</cbc:RoundingAmount> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">10.00</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">OTH</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> <cac:TaxSubtotal> <cbc:TaxableAmount currencyID="JO">495.00</cbc:TaxableAmount> <cbc:TaxAmount currencyID="JO">50.500</cbc:TaxAmount> <cac:TaxCategory> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5305">S</cbc:ID> <cbc:Percent>10.00</cbc:Percent> <cac:TaxScheme> <cbc:ID schemeAgencyID="6" schemeID="UN/ECE 5153">VAT</cbc:ID> </cac:TaxScheme> </cac:TaxCategory> </cac:TaxSubtotal> </cac:TaxTotal> <cac:Item> <cbc:Name>Malboro2 </cbc:Name> </cac:Item> <cac:Price> <cbc:PriceAmount currencyID="JO">50.00</cbc:PriceAmount> <cac:AllowanceCharge> <cbc:ChargeIndicator>false</cbc:ChargeIndicator> <cbc:AllowanceChargeReason>DISCOUNT</cbc:AllowanceChargeReason> <cbc:Amount currencyID="JO">5.00</cbc:Amount> </cac:AllowanceCharge> </cac:Price> </cac:InvoiceLine>
    'ي المثال اعلاه
    'يمكن إضافة أكرت من )سلعة أو خدمة( وذلك بتكرار بيانات) الخدمة أو السلعة( المراد إضافتها كما يظهر ف
    'دائرة ضريبة الدخل والمبيعات
    '81 الدليل التقني للربط مع نظام الفوترة الوطني
    '3 ) تجهيز وارسال ملف JSON- بعد القيام بتجهيز الفاتورة بصيغة ) XML ( يتم تشفير الملف على نظام ) Base64 ( وإدراجها في ملف JSON مع إضافة
    'Client-ID و Secret Key كما في المثال أدناه:
    'مثال يوضح عملية دمج الفاتورة بعد تشفيرها مع Client ID و Secret Key باستخدام لغة C# ResetSharpvar client = new RestClient("https://backend.jofotara.gov.jo/core/invoices/"); client.Timeout = -1; var request = new RestRequest(Method.POST); request.AddHeader("Client-Id", "رقم المستخدم "); request.AddHeader("Secret-Key", "المفتاح السري "); request.AddHeader("Content-Type", "application/json"); request.AddHeader("Cookie", "stickounet=4fdb7136e666916d0e373058e9e5c44e|7480c8b0e4ce7933ee164081a50488f1"); var body = @"{" + "\n" + @" ""invoice"": ""Encrypted XML Code""" + "\n" + @"}"; request.AddParameter("application/json", body, ParameterType.RequestBody); IRestResponse response = client.Execute(request); Console.WriteLine(response.Content);
    '- يتم إرسال ملف JSON على API التا ي لى: https://backend.jofotara.gov.jo/core/invoices/- بعد عملية الارسال يتم الرد من قبل الخادم بملف JSON يحتوي على رسائل تفيد بنجاح العملية وموائمتها للمتطلبات او
    'عدم نجاحها
    '- ي حال نجاح العملية يحتوي الملف على
    'ف QR Code يجب اظهاره على فاتورة البائع
    'ملاحظة
    'ي دائرة صريبة الدخل والمبيعات على
    'ي لشؤون الفوترة ف
    'لمزيد من الاستفسارات يمكن التواصل مع لجنة الدعم الف ن
    'الرابط التا ي لى: https://istd.gov.johttps://istd.gov.johttps://istd.gov.johttps://istd.gov.johttps://istd.gov.jo https://istd.gov.jo https://istd.gov.johttps://istd.gov.johttps://istd.gov.jo https://istd.gov.johttps://istd.gov.johttps://istd.gov.jo
End Class