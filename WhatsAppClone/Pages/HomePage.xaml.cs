using WhatsAppClone.Models;

namespace WhatsAppClone.Pages;

public partial class HomePage : ContentPage
{
    private List<ChatModel> ChatModels { get; set; }
    private ChatModel SourChat { get; set; }

    public HomePage(List<ChatModel> chatModels, ChatModel sourceChat)
    {
        InitializeComponent();

        ChatModels = chatModels;
        SourChat = sourceChat;
    }
}