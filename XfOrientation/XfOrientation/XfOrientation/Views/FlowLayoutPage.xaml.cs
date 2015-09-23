﻿using XfOrientation.Views;

namespace XfOrientation
{
  public partial class FlowLayoutPage : BaseContentPage
  {
    public FlowLayoutPage(MovieQuote movieQuote)
    {
      InitializeComponent();
      MovieQuote = movieQuote;
      BindingContext = this;
    }
    public MovieQuote MovieQuote { get; set; }
  }
}