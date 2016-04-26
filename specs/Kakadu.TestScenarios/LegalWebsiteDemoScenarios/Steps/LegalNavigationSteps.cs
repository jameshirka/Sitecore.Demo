﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Extensions;
using ClassLibrary1.Infrastructure;
using TechTalk.SpecFlow;

namespace ClassLibrary1.Steps
{
  public class LegalNavigationSteps: StepsBase
  {
    [Given(@"User has opened Legal website")]
    [Given(@"Legal website homepage is opened in private browsing session")]
    public void GivenLegalWebsiteHomepageIsOpenedInPrivateBrowsingSession()
    {
      NavigateToPage(Settings.BaseUrl);
    }

  }
}