//
//  MainPageViewController.m
//  HashGag
//
//  Created by Rob Struthers on 09/02/2014.
//  Copyright (c) 2014 HashGag. All rights reserved.
//

#import "MainPageViewController.h"

@interface MainPageViewController ()
@end

@implementation MainPageViewController

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];
    if (self) {
        
        self.currentScreenViewController = [self.storyboard instantiateViewControllerWithIdentifier:@"WinningViewController"];
    }
    return self;
}

- (void)viewDidLoad
{
    [super viewDidLoad];
    self.navigationItem.titleView = [[UIImageView alloc] initWithImage:[UIImage imageNamed:@"Nav_Bar_Logo.png"]];
    self.currentScreenViewController = [self childViewControllers][0];
    
}

- (IBAction)screenSegmentControl:(UISegmentedControl *)sender
{
    self.currentScreenViewController = [self.storyboard instantiateViewControllerWithIdentifier:@"WinningViewController"];
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.

    

}
@end
