﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Communication
{
    /// <summary>
    /// Логика взаимодействия для AddQuestion.xaml
    /// </summary>
    public partial class AddQuestion : Window
    {
        AppContext AC;
        
        public AddQuestion()
        {
            InitializeComponent();
            AC = new AppContext();
        }

        private void CommAnsButton_Click(object sender, RoutedEventArgs e)
        {
            if (QueText.Text.Contains("скрепить провод") || QueText.Text.Contains("починить провод") || QueText.Text.Contains("спаять провод") || QueText.Text.Contains("провод") || QueText.Text.Contains("провода"))
            {
                CommAns.Items.Add("Шаг 1 – Подготавливаем инструмент \n" +
                    "Для начала Вам нужно подготовить паяльник к пайке проводов своими руками.Все, что требуется – тщательно очистить жало от остатков припоя либо других возможных загрязнений\n" +
                    "Для этого можете использовать обычный напильник. Помимо этого Вы должны подготовить припой и флюс, без которых не получится паять провода паяльником.\n" +
                    "Что касается припоя, для того, чтобы спаять жилы, можно использовать либо сплав олова и свинца, либо специальную нить, как показано на фото ниже." +
                    "\nФлюс необходим для того, чтобы во время пайки припой равномерно покрыл спаиваемые материалы. Помимо этого флюс избавляет медные жилы от оксидной пленки, которая значительно ухудшает надежность соединения. " +
                    "В качестве флюса Вы можете использовать либо канифоль, либо специальную паяльную кислоту. И тот и другой вариант пользуется популярностью у мастеров." +
                    "\nЕще один важный этап подготовки – создание подходящего рабочего места. У Вас должна быть рядом розетка и подставка для паяльника, чтобы технология пайки проводов своими руками была безопасной." +
                    "\nШаг 2 – Выполняем лужение\nИтак, если Вам нужно спаять два силовых провода между собой, то первым делом Вы должны снять полиэтиленовую изоляцию и залудить оголенные жилы, особенно если они очень тонкие. Многожильный проводник перед пайкой сначала скручивается, после чего обрабатывается флюсом, поверх которого наносится тонкий слой разогретого припоя. " +
                    "Обязательно перед тем, как паять, подготовьте жало паяльника – окуните его в флюс (в ту же канифоль, как показывается на фото), а после этого в олово, чтобы кончик был покрыт небольшим слоем припоя." +
                    "\nЛужение проводов для пайки выполнить довольно просто – сначала Вы должны положить оголенную жилу на канифоль, потом прогреть это место паяльником, чтобы проводок погрузился во флюс. После этого его нужно достать и равномерно со всех сторон обработать припоем. Чтобы хорошо нанести разогретый сплав олова и свинца на поверхность, в руках прокручивайте провод во время лужения. " +
                    "Если Вам необходимо соединить жилы в распределительной коробке, для удобства вместо канифоли можете использовать кислоту. Ее достаточно просто нанести кисточкой на поверхность, которую Вам нужно спаять." +
                    "\nЕсли жилы большого сечения (толстые), лужение выполняется аналогичным образом. Отличие лишь в том, что не нужно предварительно скручивать жилы, как у многопроволочного проводника." +
                    "\nПосле того, как Вы выполните лужение, можно переходить к процессу пайки. Сразу же обращаем Ваше внимание на то, что выполнять работы необходимо только при отключенном электричестве. " +
                    "Паять провода под напряжением категорически запрещается!" +
                    "\nШаг 3 – Спаиваем жилы\nНу и последнее, что осталось – спаять два подготовленных провода в распредкоробке. Все, что нужно – скрутить либо наложить жилы друг на друга и разогреть место соединения паяльником. " +
                    "Припой расплавится и после того, как застынет – надежно соединит электрические проводники. Советы по соединению проводов пайкой  в распределительной коробке мы рассматривали отдельно." +
                    "\nВажный момент – во время пайки не двигайте жилы, иначе соединение будет не достаточно надежным.\n" +
                    "Следует также отметить, что предварительное лужение можно и не выполнять, а просто скрутить проводки а распаечной коробке, обработать их флюсом и как следует пропаять. " +
                    "Однако так паять мы Вам не рекомендуем, потому что в этом случае соединение будет на порядок хуже.");
            }
            else if (QueText.Text.Contains("Как собрать компьютер самому из комплектующих") || QueText.Text.Contains("Установка комплектующих") || QueText.Text.Contains("установить видеокарт") || QueText.Text.Contains("собрать комп") || QueText.Text.Contains("установить процессор") || QueText.Text.Contains("установить оперативную память") || QueText.Text.Contains("установить озу") || QueText.Text.Contains("установка процессора") || QueText.Text.Contains("поставить комплектующие"))
            {
                CommAns.Items.Add("В целом, сборка с нуля подразумевает следующий порядок выбора комплектующих.\nПроцессор\nСистема охлаждения, если не планируется боксовый вариант ЦПУ, который поставляется вместе с кулером в комплекте.\n" +
                    "Материнская плата\nОперативная память под материнскую плату.\nВидеокарта (если не устраивает встроенное решение).\n" +
                    "Блок питания, который по мощности потянет основные комплектующие.\nКорпус, в который всё вместится.\nНакопители.\n" +
                    "\nУстанавливаем блок питания\nХотя блок питания в большинстве случаев выбирается в последнюю очередь (потому что нужно знать, сколько будут суммарно потреблять все комплектующие, и от этого отталкиваться), мы рекомендуем начинать сборку компьютера именно с его установки внутрь корпуса. " +
                    "Почему БП следует ставить первым? Потому что из всех комплектующих он самый большой по размерам. " +
                    "Если устанавливать его на финальном этапе, можно случайно повредить остальные компоненты. " +
                    "Тем более что блок питания довольно тяжелый, и его легко выронить из рук.\n" +
                    "Для того чтобы установить БП внутрь корпуса, вам понадобится 4 винтика, которые всегда идут в комплекте. \n" +
                    "Их нужно закрутить в соответствующие отверстия на тыльной стороне комплектующей, где находится разъем для кабеля, который питает блок от сети. " +
                    "В зависимости от вашего корпуса, БП может устанавливаться, как сверху, так и снизу.\n" +
                    "\nУстанавливаем материнскую плату\n" +
                    "осле установки блока питания желательно максимально оснастить материнскую плату и установить ее внутрь корпуса. \n" +
                    "Под максимальным оснащением мы подразумеваем: установку процессора в сокет, установку кулера на процессор, установку всех планок оперативной памяти. И только видеокарту следует отложить в конец списка.\n" +
                    "Почему именно так? Сейчас объясним специально для тех, кто в первый раз решает задачу собрать ПК самому с нуля:.\n" +
                    "Сама установка материнской платы очень проста. Достаточно просто закрутить шурупы в соответствующие разъемы. Намного сложнее выбрать материнку. " +
                    "\nВо-первых, она должна иметь сокет, который поддерживает процессор. Также слоты под оперативную память должны иметь такой же тип, как сама ОЗУ. " +
                    "Не забудьте проверить количество слотов и максимально поддерживаемый объем памяти. " +
                    "Ко всему прочему форм-фактор материнской платы, как и в случае с блоком питания, должен быть совместим с корпусом. " +
                    "\n\nУстанавливаем ЦПУ и систему охлаждения\n" +
                    "Один из самых простых шагов во всей сборке. У каждого процессора в левом нижнем углу есть маркировка в виде треугольника. " +
                    "Такой же значок имеется и на сокете на материнской плате. " +
                    "Они должны совпасть таким образом, чтобы оба находились в одном углу. " +
                    "\nПеред установкой не забудьте отогнуть соответствующую защелку на месте установки ЦПУ. " +
                    "После того, как «камень» установлен в сокет, защелку необходимо вернуть в изначальное положение. " +
                    "Таким образом, вы зафиксируете комплектующую. Будьте предельно аккуратны, чтобы не погнуть ножки процессора.\n" +
                    "\nПосле этого на крышку процессора наносится термопаста и устанавливается кулер. " +
                    "Если ЦПУ приобретался боксового формата, то на основании радиатора кулера уже будет нанесен термоинтерфейс. " +
                    "\nНаносить еще один на крышку процессора не нужно! " +
                    "Как правило, охлаждение, как и блок питания, фиксируется 4 винтиками, которые находятся на материнской плате чуть дальше от каждого угла процессора. " +
                    "\n\nУстанавливаем оперативную память\n" +
                    "ОЗУ достаточно просто воткнуть в соответствующие слоты. " +
                    "По краям посадочных мест находятся защелки: их необходимо отогнуть и вставить планки. " +
                    "\nО правильной установке можно судить по характерному щелчку, который означает, что фиксаторы вернулись в исходное положение. " +
                    "В этом деле не потребуется даже отвертка." +
                    "\n\nУстановка Видеокарты\n" +
                    " Установка графического адаптера схожа с установкой оперативной памяти. Его необходимо поставить в соответствующий слот, который находится в нижней части материнской платы. " +
                    "На коннекторе также имеется защелка, которую нужно отогнуть перед установкой комплектующей, и которая также защелкнется, если установить GPU до конца. " +
                    "\nНо делать это следует в последнюю очередь. Как мы и писали выше, карточка может перекрыть остальные разъемы, например, которые отвечают за подключение жестких дисков. " +
                    "Поэтому видеокарту следует устанавливать в самую последнюю очередь. Сначала подключите все провода!");
            }
            else if (QueText.Text.Contains("гудит") || QueText.Text.Contains("трещит") || QueText.Text.Contains("скрипит") || QueText.Text.Contains("издает звуки") || QueText.Text.Contains("гудит при включении"))
            {
                CommAns.Items.Add("Способ 1\nГлавной причиной, по которой компьютер начинает гудеть, является пыль. " +
                    "Вентиляторы внутри компьютера продувают воздух через радиаторы охлаждения, на которых со временем образуются пыльные пробки. " +
                    "Охлаждение компьютера от этого ухудшается.\n\n" +
                    "Способ 2\nСмажьте вентиляторы\nПри желании можно сразу заменить элементы новыми, но всё же есть смысл для начала попытаться смазать вентиляторы. " +
                    "Процедуру стоит повторять примерно раз в год. " +
                    "Отключите кабель кулера от материнской платы или блока питания. " +
                    "С помощью отвёртки выкрутите крепёжные винты и снимите вентилятор.");
            }
            else if (QueText.Text.Contains("компьютер пищит") || QueText.Text.Contains("сигналы с компьютера") || QueText.Text.Contains("сигналы при включении компьютера") || QueText.Text.Contains("пикнул 1 раз") || QueText.Text.Contains("пикнул 2 раза") || QueText.Text.Contains("пикнул 3 раза")) {
                CommAns.Items.Add("* Один короткий писк.\nРасшифровка:Все прекрасно. Тест пройден успешно. Можно продолжать работать. Бывает так, что некоторые системные блоки вообще в этот момент не пищат." +
                    "\n* Нет ни писка, не изображения на экране компьютера.\nРасшифровка:Неисправности в блоке питания, или процессоре." +
                    "\nИсправление:Для начала посмотрите, включен ли шнур питания в розетку.Если все в порядке, попробуйте подключить к сетевому фильтру(такой шнур с коробочкой, в которой много розеток, там еще кнопочка - включатель есть, красная обычно) заведомо работаюший девайс.Подойдет зарядник для телефона, естественно, с подключенным к нему телефоном." +
                    "Проверить надо все розетки сетевого фильтра.Если розетка исправна, то телефон будет заряжаться." +
                    "Далее проверяем, запускается - ли блок питания при нажатии кнопки запуска компьютера.При этом кулер(вентилятор) блока питания долже хотя бы дернуться.Если движение есть – ищите новый процессор, иначе – новый блок питания.Так - же нужно проверить кабель питания матнринской платы.Может случится, что он отошел." +
                    "\n* Один длинный непрерывный писк.\nРасшифровка:Неисправен блок питания.\nИсправление:Приобретение нового блока питания.\n" +
                    "* Два коротких писка.\nРасшифровка:Незначительные неисправности в настройках BIOS.\n" +
                    "Исправление:Пройти в BIOS и установить оптимальные параметры.Выход в BIOS осуществляется, обычно, клавишей[DEL]." +
                    "Если Вы не знаете, что изменить, то установите значения по умолчанию.Для этого нажимаете кнопку[F5]." +
                    "Для выхода с сохранением – [F10], [Enter].Некоторые версии BIOS сами подсказывают подсветкой конфликтующие пункты настроек. " +
                    "Еще, обнулить настройки BIOS можно вынув батарейку питания материнской платы на несколько секунд.\n" +
                    "* Три длинных писка.\nРасшифровка:Отсутствует клавиатура.\n" +
                    "* Три коротких писка.\nРасшифровка:Ошибка оперативной памяти.\n" +
                    "Исправление:Для этого нужно проверить, есть - ли планки памяти на материнской плате." +
                    "Не смейтесь, бывает и такое." +
                    "Потом нужно вынуть все планки памяти, аккуратно смести скопившуюся пыль, и поочередно втыкать планку памяти, и запускать системник." +
                    "Если на какой - то планке (системник) пропищит, то это может означать, что планка неисправна.\n" +
                    "* Один длинный и один короткий писк.\nРасшифровка:Неправильно работает оперативная память.\nИсправление:Возможно, какая - то одна или несколько планок памяти конфликтуют между собой." +
                    "Нужно поочереди втыкать по одной планке памяти и пытаться запустить компьютер." +
                    "\n* Один длинный и два коротких писка.\nРасшифровка:Неправильно работает видеоадаптер.\nИсправление:Исправить настройки в BIOS.\n" +
                    "* Один длинный и три коротких писка.\nРасшифровка:Не работает видеоадаптер.\n" +
                    "Исправление:Проверить работоспособность видеокарты.Для этого нужна другая, заведомо работающая видеокарта." +
                    "Так - же можно попробовать вынуть карту, удалить со слота пыль, и воткнуть карту на место.И незабыть проверить, имеются ли на карте дополнительные штекеры для питания." +
                    "Питание к таким видеокартам нужно давать отдельным шнуром, к которому не подключен ни один девайс." +
                    "Предлагаю еще проверить, подключен - ли монитор и работает - ли." +
                    "Попробуйте продуть штекер подключения монитора к компьютеру.\n" +
                    "* Один длинный и восемь коротких писка.(тоже самое, что написано выше)\n" +
                    "* Один длинный и девять коротких писка.\n" +
                    "Расшифровка:Ошибка считывания данных BIOS.\nИсправление:Попробовать обнулить настройки BIOS выниманием батарейки.Если это не поможет, то перепрошивка BIOS." +
                    "* Четыре коротких писка.\nРасшифровка:Не работает системный таймер.\n" +
                    "Исправление:Можно попробовать обнулить BIOS.Но, к сожалению, помогает редко.Выход один – сменить или отремонтировать материнскую плату." +
                    "\n* Пять коротких писка.\n" +
                    "Расшифровка:Неправильно работает процессор.\nИсправление:Попробовать вычистить пыль со слота процессора, убедиться в чистоте радиатора и невысокой температуре процессора." +
                    "* Девять коротких писка.\n" +
                    "Расшифровка:Неправильная контрольная сумма BIOS.\n" +
                    "Исправление:Обычно предлагается обнулить настройки BIOS и позволяет работать далее." +
                    "В случае чего, можно обнулить BIOS выниманием батарейки питания." +
                    "\n* Десять коротких писка.\n" +
                    "Расшифровка:Ошибка записи данных в микросхему CMOS.\n" +
                    "Исправление:Эта ошибка может возникнуть при перепрошивке BIOS.\n" +
                    "* Одиннадцать коротких писков.\n" +
                    "Расшифровка:Неправильно работает кэш память.\nИсправление:Сброс BIOS." +
                    "В случае, если это не поможет, несем комп в ремонт, или устанавливаем новый процессор." +
                    "\n* Повторяющиеся длинные писки.\nРасшифровка:Неисправна, либо неправильно подключена оперативная память.\n" +
                    "Исправление:Переподключение планок памяти.Вычисление неисправной, путем подключения по очереди и запуска компьютера.Очистка от пыли." +
                    "\n* Повторяющиеся короткие писки.Расшифровка:Неправильно работает блок питания.\nИсправление:Проверка работоспособности блока питани, проверка шнуров на обрыв, проверка сетевого фильтра, и, в последнюю очередь, замена блока питания.");
            }
        }

        private void YesMainButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Question questionW = new Question(QueText.Text, CommAns.Items[0].ToString());

                AC.Questions.Add(questionW);
                AC.SaveChanges();
                var f = AC.Questions.Where(c => c.Questione == QueText.Text).FirstOrDefault();
                var w = AC.Users.Where(c => c.login == NowClass.NOW).FirstOrDefault();
                w.questionId += f.ID.ToString() + " ,";
                AC.SaveChanges();
                CommunicationWindow communicationWindow = new CommunicationWindow();
                communicationWindow.Show();
                this.Close();
            }
            catch {
                MessageBox.Show("Приложение не смогло ответить на ваш вопрос. Отправте ваш вопрос эксперту", "Communication", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AdminQueButton_Click(object sender, RoutedEventArgs e)
        {
            if (QueText.Text == null || QueText.Text == "" || QueText.Text == " ")
            {
                MessageBox.Show("Вы ничего не ввели. Напишите ваш вопрос", "Communication", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Question questionW = new Question(QueText.Text, "");

                AC.Questions.Add(questionW);
                AC.SaveChanges();
                var f = AC.Questions.Where(c => c.Questione == QueText.Text).FirstOrDefault();
                var r = AC.Users.Where(c => c.RoleID == 2).FirstOrDefault();
                var w = AC.Users.Where(c => c.login == NowClass.NOW).FirstOrDefault();
                w.questionId += f.ID.ToString() + " ,";
                AC.SaveChanges();
                r.questionId += f.ID.ToString() + " ,";
                AC.SaveChanges();
                CommunicationWindow communicationWindow = new CommunicationWindow();
                communicationWindow.Show();
                this.Close();
                MessageBox.Show("Вопрос отправлен эксперту", "Communication", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            CommunicationWindow communicationWindow = new CommunicationWindow();
            communicationWindow.Show();
            this.Close();
        }

        //функции для юнит тестов
        public string AppAns(string res, string ans) {
            if (ans.Contains("скрепить провод") || ans.Contains("починить провод") || ans.Contains("спаять провод") || ans.Contains("провод") || ans.Contains("провода"))
            {
                return res = "Успешно!";
            }
            else if (ans.Contains("Как собрать компьютер самому из комплектующих") || ans.Contains("Установка комплектующих") || ans.Contains("установить видеокарт") || ans.Contains("собрать комп") || ans.Contains("установить процессор") || ans.Contains("установить оперативную память") || ans.Contains("установить озу") || ans.Contains("установка процессора") || ans.Contains("поставить комплектующие"))
            {
                return res = "Успешно!";
            }
            else if (ans.Contains("гудит") || ans.Contains("трещит") || ans.Contains("скрипит") || ans.Contains("издает звуки") || ans.Contains("гудит при включении"))
            {
                return res = "Успешно!";
            }
            else if (ans.Contains("компьютер пищит") || ans.Contains("сигналы с компьютера") || ans.Contains("сигналы при включении компьютера") || ans.Contains("пикнул 1 раз") || ans.Contains("пикнул 2 раза") || ans.Contains("пикнул 3 раза"))
            {
                return res = "Успешно!";
            }
            else {
                return res = "Ошибка";
            }
        }
    }
}
