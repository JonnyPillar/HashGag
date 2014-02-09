//
//  WinningViewController.m
//  HashGag
//
//  Created by Rob Struthers on 09/02/2014.
//  Copyright (c) 2014 HashGag. All rights reserved.
//

#import "WinningViewController.h"
#import "UserScoreTableCell.h"

@interface WinningViewController ()

@end

@implementation WinningViewController

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil
{
    self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil];
    if (self) {
        // Custom initialization
//        self.tableView.delegate = self;
//        self.tableView.dataSource = self;
//        self.tableView.rowHeight = 90;
//        self.tableView.allowsSelection = NO;
    }
    return self;
}

- (void)viewDidLoad
{
    [super viewDidLoad];
	// Do any additional setup after loading the view.
}

- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView
{
    // Return the number of sections.
    return 1;
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section
{
    // Return the number of rows in the section.
    return 10;
}

- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath
{
    UserScoreTableCell *cell = [tableView dequeueReusableCellWithIdentifier:@"UserCell"];
    
    cell.userImage.image = nil;
    cell.scoreLabel.text = @"11";
    cell.timeLabel.text = @"12 hrs 48 mins";
    cell.hashtagLabel.text = @"#Hackathon";
        return cell;
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
