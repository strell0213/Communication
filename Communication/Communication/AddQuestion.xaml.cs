using System;
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
            if (QueText.Text.Contains("скрепить провод") || QueText.Text.Contains("починить провод") || QueText.Text.Contains("спаять провод"))
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
            else if (QueText.Text.Contains("") || QueText.Text.Contains("")) { 
            
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
}
